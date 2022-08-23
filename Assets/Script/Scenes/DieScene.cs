using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieScene : MonoBehaviour
{
    void Start()
    {
        Init();   
    }

    void Init()
    {

    }

    public void Replay()
    {
        Clean();
        ReLoad();

        Time.timeScale = 1.0f;
    }

    public void Exit()
    {
        Application.Quit();
    }

    void Clean()
    {
        GameManager.Destroy("YOUDIED");
        GameManager.Destroy("Player");
        GameManager.Destroy("PlayerScore");
        GameManager.Destroy("PlayerHp");
        GameManager.Destroy("Opossum");
        GameManager.Destroy("Eagle");
        GameManager.Destroy("Frog");
    }

    void ReLoad()
    {
        GameManager.InstantiatePlayer("Player");
        GameManager.InstantiatePlayer("PlayerScore");
        GameManager.InstantiatePlayer("PlayerHp");
        GameManager.InstantiateMonster("Opossum");
        GameManager.InstantiateMonster("Eagle");
        GameManager.InstantiateMonster("Frog");
    }
}
