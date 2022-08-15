using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    private GameObject _prefab;
    GameObject _player;

    void Start()
    {
        Init();
    }

    void Init()
    {
        _prefab = Resources.Load<GameObject>("Prefabs/Player");
        _player = Instantiate(_prefab);
    }
}
