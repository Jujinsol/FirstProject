using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Define;

public class MonsterController : CreatureController
{
    float _speed = 3.0f;
    int _changeDir;

    FinalDir _finalDir;

    public FinalDir FinalDir
    {
        get { return _finalDir; }
        set
        {
            if (_finalDir == value) // 변화가 없을 때
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
        _animator = GetComponent<Animator>();
        Init();
    }

    void FixedUpdate()
    {
        Move();
    }

    protected override void Init()
    {
        Vector3 pos = new Vector3(10, -2.2f, 0);
        transform.position = pos;
        StartCoroutine("ChangeDir");
        FinalDir = FinalDir.Left;
    }

    void Move()
    {
        if (_changeDir == 0)
        {
            transform.position += Vector3.right * _speed * Time.deltaTime;
            FinalDir = FinalDir.Right;
        }
        else if (_changeDir == 1)
        {
            transform.position += Vector3.left * _speed * Time.deltaTime;
            FinalDir = FinalDir.Left;
        }            
    }

    IEnumerator ChangeDir()
    {
        _changeDir = 1;
        yield return new WaitForSeconds(6.5f);
        _changeDir = 0;
        yield return new WaitForSeconds(6.5f);
        StartCoroutine("ChangeDir");
    }
}
