using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Define;

public class CreatureController : MonoBehaviour
{
    protected Animator _animator;
    protected MoveDir _dir;

    void Start()
    {
        Init();
    }

    void Update()
    {
        
    }

    protected virtual void Init()
    {
    }
}
