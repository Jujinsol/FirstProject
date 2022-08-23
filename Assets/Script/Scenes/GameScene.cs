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
        GameManager.InstantiateMap("Map");

        GameManager.InstantiateUI("EventSystem");

        GameManager.InstantiatePlayer("Player");
        GameManager.InstantiatePlayer("PlayerScore");
        GameManager.InstantiatePlayer("PlayerHp");

        GameManager.InstantiateMonster("Opossum");
        GameManager.InstantiateMonster("Eagle");
        GameManager.InstantiateMonster("Frog");
    }
}
