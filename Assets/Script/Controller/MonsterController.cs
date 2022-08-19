using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Define;

public class MonsterController : MonoBehaviour
{
    public virtual float Speed { get; set; }
    protected int _changeDir;

    protected Animator _animator;
    FinalDir _finalDir;

    protected virtual FinalDir FinalDir
    {
        get { return _finalDir; }
        set
        {
            if (_finalDir == value)
                return;

            switch (value)
            {
                case FinalDir.Left:
                    _animator.Play("WALK_LEFT");
                    transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                    break;
                case FinalDir.Right:
                    _animator.Play("WALK_LEFT");
                    transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
                    break;
            }
            _finalDir = value;
        }
    }

    void Start()
    {
        Init();
    }

    void FixedUpdate()
    {
        Move();
    }

    protected virtual void Init()
    {
        _animator = GetComponent<Animator>();
        FinalDir = FinalDir.Left;
    }
    
    protected virtual void Move()
    {
        if (_changeDir == 0)
        {
            transform.position += Vector3.right * Speed * Time.deltaTime;
            FinalDir = FinalDir.Right;
        }
        else if (_changeDir == 1)
        {
            transform.position += Vector3.left * Speed * Time.deltaTime;
            FinalDir = FinalDir.Left;
        }
    }

    protected virtual IEnumerator FromRight(float time)
    {
        _changeDir = 1;
        yield return new WaitForSeconds(time);
        _changeDir = 0;
        yield return new WaitForSeconds(time);
        StartCoroutine("FromRight", time);
    }

    protected virtual IEnumerator FromLeft(float time)
    {
        _changeDir = 0;
        yield return new WaitForSeconds(time);
        _changeDir = 1;
        yield return new WaitForSeconds(time);
        StartCoroutine("FromLeft", time);
    }
}
