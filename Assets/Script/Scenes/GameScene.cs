using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    void Start()
    {
        Init();
    }

    void Init()
    {
        GameObject _playerPrefab = Resources.Load<GameObject>("Prefabs/Player");
        GameObject _player = Instantiate(_playerPrefab);

        GameObject _OpossumPrefab = Resources.Load<GameObject>("Prefabs/Opossum");
        GameObject _opossum = Instantiate(_OpossumPrefab);
    }
}
