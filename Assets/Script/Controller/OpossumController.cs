using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Define;

public class OpossumController : MonsterController
{
    Vector3 pos = new Vector3(11, -2.2f, 0);
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
        _speed = 3.0f;
        base.Init();
        StartCoroutine("FromRight", 6.5f);
    }

    protected override void Move()
    {
        base.Move();
    }

    protected override IEnumerator FromRight(float time)
    {
        return base.FromRight(time);
    }
}
