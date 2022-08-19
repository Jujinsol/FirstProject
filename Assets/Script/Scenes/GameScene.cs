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
        GameObject _playerHpPrefab = Resources.Load<GameObject>("Prefabs/PlayerHp");
        GameObject _playerHp = Instantiate(_playerHpPrefab);

        GameObject _playerPrefab = Resources.Load<GameObject>("Prefabs/Player");
        GameObject _player = Instantiate(_playerPrefab);

        GameObject _opossumPrefab = Resources.Load<GameObject>("Prefabs/Monster/Opossum");
        GameObject _opossum = Instantiate(_opossumPrefab);

        GameObject _eaglePrefab = Resources.Load<GameObject>("Prefabs/Monster/Eagle");
        GameObject _eagle = Instantiate(_eaglePrefab);

        GameObject _fogPrefab = Resources.Load<GameObject>("Prefabs/Monster/Frog");
        GameObject _frog = Instantiate(_fogPrefab);
    }
}
