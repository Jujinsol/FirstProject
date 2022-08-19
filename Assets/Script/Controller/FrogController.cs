using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Define;

public class FrogController : MonsterController
{
    Vector3 pos = new Vector3(-11, -2, 0);
    public float _speed;

    public override float Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    protected override FinalDir FinalDir
    {
        get => base.FinalDir;
        set => base.FinalDir = value;
    }

    protected override void Init()
    {
        transform.position = pos;
        _speed = 2.0f;
        base.Init();
        StartCoroutine("FromLeft", 10.0f);
    }

    protected override void Move()
    {
        base.Move();
    }

    protected override IEnumerator FromLeft(float time)
    {
        return base.FromLeft(time);
    }
}
