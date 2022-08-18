using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using static Define;

public class PlayerController : CreatureController
{
    float _speed = 7.0f;
    float _jumpPower = 10.0f;
    bool _isGround;

    FinalDir _finalDir;

    public MoveDir Dir
    {
        get { return _dir; }
        set
        {
            if (_dir == value) // 변화가 없을 때
                return;

            switch (value)
            {
                case MoveDir.Left:
                    _animator.Play("WALK_RIGHT");
                    transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
                    _finalDir = FinalDir.Left;
                    break;
                case MoveDir.Right:
                    _animator.Play("WALK_RIGHT");
                    transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                    _finalDir = FinalDir.Right;
                    break;
                //case MoveDir.Up:
                //    _animator.Play("JUMP");
                //    transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //    break;
                case MoveDir.None:
                    if (_finalDir == FinalDir.Left)
                    {
                        _animator.Play("IDLE");
                        transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
                    }
                    else if (_finalDir == FinalDir.Right)
                    {
                        _animator.Play("IDLE");
                        transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                    }
                    else
                    {
                        _animator.Play("IDLE");
                        transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                    }
                    break;
            }
            _dir = value;
        }
    }

    void Start()
    {
        _animator = GetComponent<Animator>();
        Init();
    }

    void Update()
    {
        Moving();
    }

    protected override void Init() 
    {
        Vector3 pos = new Vector3(0, -2, 0);
        transform.position = pos;
        Dir = MoveDir.None;
    }

    void OnCollisionEnter2D(Collision2D collision) //충돌 감지
    {
        if (collision.gameObject.tag == "Ground")
            _isGround = true;
        Dir = MoveDir.None;
    }

    protected virtual void Moving()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Dir = MoveDir.Left;
            transform.position += Vector3.left * Time.deltaTime * _speed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Dir = MoveDir.Right;
            transform.position += Vector3.right * Time.deltaTime * _speed;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && _isGround)
        {
            _isGround = false;
            Dir = MoveDir.Up;
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
        }
        else
        {
            Dir = MoveDir.None;
        }
    }
}
