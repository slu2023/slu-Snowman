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

    public GameObject GameWonScreen;

    public UnityEngine.UI.Image Snowman0;
    public UnityEngine.UI.Image Snowman1;
    public UnityEngine.UI.Image Snowman2;
    public UnityEngine.UI.Image Snowman3;
    public UnityEngine.UI.Image Snowman4;

    public AudioSource CarnivalMusic;

    public AudioSource villageMusic;
    



    public void StartGame()
    {
        CarnivalMusic.Stop();
        villageMusic.Play();
        this.guessingGame = new WordGame("travel", 6);
        this.HiddenWord.text = this.guessingGame.GetWord();
        this.GuessAletter.text = "Guess a letter.";

        this.Snowman0.gameObject.SetActive(true);
        this.Snowman1.gameObject.SetActive(false);
        this.Snowman2.gameObject.SetActive(false);
        this.Snowman3.gameObject.SetActive(false);
        this.Snowman4.gameObject.SetActive(false);

        Debug.Log(this.guessingGame.GetWord());
        Debug.Log(this.guessingGame.GetFullWord());

        this.PlayScreen.gameObject.SetActive(true);
        this.StartScreen.gameObject.SetActive(false);
        this.GameOverScreen.SetActive(false);
        this.GameWonScreen.SetActive(false);


    }

    public void OpenStartScreen()
    {
        CarnivalMusic.Play();
        villageMusic.Stop();
        this.Message.text = this.Message.text = "Hi!!";
        this.PlayScreen.SetActive(false);
        this.StartScreen.SetActive(true);
        this.GameOverScreen.SetActive(false);
        this.GameWonScreen.SetActive(false);


    }

    public void Start()
    {
        this.Message.text = this.Message.text = "Welcome to Snowman";
        this.PlayScreen.SetActive(false);
        this.GameOverScreen.SetActive(false);
        this.GameWonScreen.SetActive(false);


        this.StartScreen.SetActive(true);
        this.guessingGame = new WordGame("travel", 6);
        this.HiddenWord.text = this.guessingGame.GetWord();
        Debug.Log(this.guessingGame.GetFullWord());
    }

    public void SubmitGuess()
    {
        this.GuessAletter.text = this.guessingGame.CheckGuess(this.PlayerGuess.text);
        this.HiddenWord.text = this.guessingGame.GetWord();

        if (this.guessingGame.GetIncorrectGuesses() == 0)
        {
            this.Snowman0.gameObject.SetActive(true);
            this.Snowman1.gameObject.SetActive(false);
            this.Snowman2.gameObject.SetActive(false);
            this.Snowman3.gameObject.SetActive(false);
            this.Snowman4.gameObject.SetActive(false);
        }
        if (this.guessingGame.GetIncorrectGuesses() == 1)
        {
            this.Snowman0.gameObject.SetActive(false);
            this.Snowman1.gameObject.SetActive(true);
            this.Snowman2.gameObject.SetActive(false);
            this.Snowman3.gameObject.SetActive(false);
            this.Snowman4.gameObject.SetActive(false);
        }

        if (this.guessingGame.GetIncorrectGuesses() == 2)
        {
            this.Snowman0.gameObject.SetActive(false);
            this.Snowman1.gameObject.SetActive(false);
            this.Snowman2.gameObject.SetActive(true);
            this.Snowman3.gameObject.SetActive(false);
            this.Snowman4.gameObject.SetActive(false);
        }

        if (this.guessingGame.GetIncorrectGuesses() == 3)
        {
            this.Snowman0.gameObject.SetActive(false);
            this.Snowman1.gameObject.SetActive(false);
            this.Snowman2.gameObject.SetActive(false);
            this.Snowman3.gameObject.SetActive(true);
            this.Snowman4.gameObject.SetActive(false);
        }

        if (this.guessingGame.GetIncorrectGuesses() == 4)
        {
            this.Snowman0.gameObject.SetActive(false);
            this.Snowman1.gameObject.SetActive(false);
            this.Snowman2.gameObject.SetActive(false);
            this.Snowman3.gameObject.SetActive(false);
            this.Snowman4.gameObject.SetActive(true);
        }

        if (this.guessingGame.IsGameOver())
        {
            this.PlayScreen.SetActive(false);
            this.StartScreen.SetActive(false);
            this.GameOverScreen.SetActive(true);
            this.GameWonScreen.SetActive(false);
        }

        if (this.guessingGame.IsGameWon())
        {
            this.PlayScreen.SetActive(false);
            this.StartScreen.SetActive(false);
            this.GameOverScreen.SetActive(false);
            this.GameWonScreen.SetActive(true);
        }

    }

    // public void SubmitGuess
}

