using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGuess : MonoBehaviour
{
    int myGuess;
    int max;
    int min;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to Number Game");
        Debug.Log("Pick a number in your head, but don't tell me!");
        max = 1000;
        min = 1;
        myGuess = 500;
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + myGuess);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = myGuess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = myGuess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am a genius!");
        }
    }

    void NextGuess()
    {
        myGuess = (max + min) / 2;
        Debug.Log("Is it higher or lower than..." + myGuess);
    }
}
