using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WordGuesser;

public class Gamecontroller : MonoBehaviour
{
    public UnityEngine.UI.Text Message;

    public UnityEngine.UI.Button StartButton;

    public GameObject StartScreen;
    public GameObject PlayScreen;
    private WordGame guessingGame;


    public void StartGame()
    {
        this.guessingGame = new WordGame("banana", 5);
        Debug.Log(this.guessingGame.GetWord());
        Debug.Log(this.guessingGame.GetFullWord());

        this.PlayScreen.gameObject.SetActive(true);
        this.StartScreen.gameObject.SetActive(false);
    }

    public void OpenStartScreen()
    {
        this.Message.text = this.Message.text = "hello!!!!!!";
        this.PlayScreen.SetActive(false);
        this.StartScreen.SetActive(true);
    }

    public void Start()
    {
        this.Message.text = this.Message.text = "hello!!!!!!";
        this.PlayScreen.SetActive(false);
        this.StartScreen.SetActive(true);
    }


}

