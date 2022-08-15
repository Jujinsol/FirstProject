using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Define;

public class PlayerController : MonoBehaviour
{
    public float _speed = 10.0f;
    MoveDir _dir = MoveDir.None;

    void Start()
    {
        Init();
    }

    void Update()
    {
        GetDirInput();
    }

    protected virtual void Init() 
    {
        Vector3 pos = new Vector3(0, -2, 0);
        transform.position = pos;
    }

    protected virtual void GetDirInput()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            _dir = MoveDir.Left;
            transform.position += Vector3.left * Time.deltaTime * _speed;
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            _dir = MoveDir.Right;
            transform.position += Vector3.right * Time.deltaTime * _speed;
        }
    }
}
