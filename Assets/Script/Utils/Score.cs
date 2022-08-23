using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private float _score;

    private Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        _score += Time.deltaTime;
        text.text = $"Á¡¼ö : {_score:N1}";
    }
}
