using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static void InstantiateMonster(string Name)
    {
        GameObject go = Instantiate(Resources.Load<GameObject>($"Prefabs/Monster/{Name}"));
        go.name = Name;
    }

    public static void InstantiatePlayer(string Name)
    {
        GameObject go = Instantiate(Resources.Load<GameObject>($"Prefabs/{Name}"));
        go.name = Name;
    }

    public static void InstantiateUI(string Name)
    {
        GameObject go = Instantiate(Resources.Load<GameObject>($"Prefabs/UI/{Name}"));
        go.name = Name;
    }

    public static void InstantiateMap(string Name)
    {
        GameObject go = Instantiate(Resources.Load<GameObject>($"Prefabs/Map/{Name}"));
        go.name = Name;
    }

    public static void Destroy(string Name)
    {
        GameObject go = GameObject.Find(Name);
        if (go == null)
            return;
        Destroy(go);
    }
}
