using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WordGuesser;

public class Gamecontroller : MonoBehaviour
{
    public UnityEngine.UI.Text Message;
    public UnityEngine.UI.Text HiddenWord;
    public UnityEngine.UI.Text GuessAletter;

    public UnityEngine.UI.Button StartButton;

    public GameObject StartScreen;
    public GameObject PlayScreen;
    private WordGame guessingGame;
    public UnityEngine.UI.Text Title;
    public UnityEngine.UI.InputField PlayerGuess;

    public GameObject GameOverScreen;


    public void StartGame()
    {
        this.guessingGame = new WordGame("banana", 5);
        Debug.Log(this.guessingGame.GetWord());
        Debug.Log(this.guessingGame.GetFullWord());

        this.PlayScreen.gameObject.SetActive(true);
        this.StartScreen.gameObject.SetActive(false);
        this.GameOverScreen.SetActive(false);

    }

    public void OpenStartScreen()
    {
        this.Message.text = this.Message.text = "Hi!!";
        this.PlayScreen.SetActive(false);
        this.StartScreen.SetActive(true);
        this.GameOverScreen.SetActive(false);

    }

    public void Start()
    {
        this.Message.text = this.Message.text = "Welcome to Snowman";
        this.PlayScreen.SetActive(false);
        this.GameOverScreen.SetActive(false);

        this.StartScreen.SetActive(true);
        this.guessingGame = new WordGame("banana", 5);
        this.HiddenWord.text = this.guessingGame.GetWord();
        Debug.Log(this.guessingGame.GetFullWord());
    }

    public void SubmitGuess()
    {
        this.GuessAletter.text = this.guessingGame.CheckGuess(this.PlayerGuess.text);
        this.HiddenWord.text = this.guessingGame.GetWord();

        if (this.guessingGame.IsGameOver())
        {
            this.Message.text = this.Message.text = "You lose! Now you're like this dude..";
            this.PlayScreen.SetActive(false);
            this.StartScreen.SetActive(false);
            this.GameOverScreen.SetActive(true);

        }

    }

    // public void SubmitGuess
}

