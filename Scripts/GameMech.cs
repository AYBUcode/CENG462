using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameMech : MonoBehaviour
{
    private int guess, min, max;
    [SerializeField] TextMeshProUGUI guessText;

    void Start()
    {
        guess = Random.Range(1, 1000);
        guessText.text = guess.ToString();
        min = 1;
        max = 1000;
    }

    public void OnHigher()
    {
        min = guess + 1;
        guess = Random.Range(min, max);
        guessText.text = guess.ToString();
    }

    public void OnLower()
    {
        max = guess - 1;
        guess = Random.Range(min, max);
        guessText.text = guess.ToString();
    }
}
