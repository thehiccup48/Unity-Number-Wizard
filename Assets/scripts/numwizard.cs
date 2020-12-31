using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numwizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;    
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        Debug.Log("Welcome To Number Wizard");
        Debug.Log("Please choose a number, dont tell me what it is");
        Debug.Log("the hightest number is: " + max);
        Debug.Log("the lowest number is: " + min);
        Debug.Log("-------------------------------------------");
        Debug.Log("-------------------------------------------");
        Debug.Log("tell me if your nomber is higher or lower than " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower Push Enter = Correct");
        max += 1;
        max = 1000;
        min = 1;
        guess = 500;
    }

    // Update is called once per frame
    void Update()
    {
        guess = (min + max) / 2;
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("IM RIGHT!");
            Debug.Log("I mean of caorse Im right why whouldent i be");
            StartGame();
        }
        void NextGuess()
        {
            guess = (min + max) / 2;
            Debug.Log("is it higher or lower than" + guess);
        }
    }
}
