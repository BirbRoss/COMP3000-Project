using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class gameManager : MonoBehaviour
{
    [Header("Starting the Game")]
    [SerializeField] OrbitAndFire shooter;
    [SerializeField] GameObject controllerRay;
    [SerializeField] Canvas startCanvas;

    [Header("Ending the Game")]
    [SerializeField] Canvas endCanvas;

    [Header("Scoring")]
    [SerializeField] float scorePer = 1.0f;
    float score = 0;
    [SerializeField] public TextMeshProUGUI[] scoreBoxes;
    [SerializeField] public TextMeshProUGUI[] timeBoxes;
    [SerializeField] float timeLeft = 30;
    bool timerTicking = true;


    //Runs when the start button is pressed, enables the shooter, disables the intro text & ray before starting the timer
    public void beginGame()
    {
        //Disables the ray and canvas so they don't confuse the player, then lets the ball shooter start moving.
        shooter.enabled = !shooter.enabled;
        controllerRay.SetActive(false);
        startCanvas.enabled = !startCanvas.enabled;
        timerTicking = false;
    }

    //Adds points to the score when called and an extra second of time
    public void addPoints()
    {
        //Adds more score for difficulty
        score = score++ + (shooter.difficulty / 2);
        timeLeft++;

        //updates score & time text boxes
        for (int i = 0; i < scoreBoxes.Length; i++)
        {
            scoreBoxes[i].text = score.ToString();
        }

        for (int i = 0; i < timeBoxes.Length; i++)
        {
            timeBoxes[i].text = timeLeft.ToString();
        }
    }

    //Resets scene when called
    public void resetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    //Enables the end text, reset button & enables the pointer ray
    void endGame()
    {
        shooter.enabled = !shooter.enabled;
        controllerRay.SetActive(true);
        endCanvas.enabled = !endCanvas.enabled;
    }

    //Will tick the timer when possible, if the timer hits 0 it ends the game
    void Update()
    {
        //Ticks if there's more than 0 seconds left and will only end the game when the timer stops
        if (!timerTicking && timeLeft > 0)
        {
            StartCoroutine(Timer());
        }

    }

    public void quiter()
    {
        Application.Quit();
    }


    //Prevents the timer form ticking again before counting a second, changing the variables and textboxes appropriately
    IEnumerator Timer()
    {
        timerTicking = true;
        yield return new WaitForSeconds(1);
        timeLeft--;

        for (int i = 0; i < timeBoxes.Length; i++)
        {
            timeBoxes[i].text = timeLeft.ToString();
        }

        //Ends the game if there is no time left
        if (timeLeft <= 0)
        {
            timerTicking = true;
            endGame();
        }
        timerTicking = false;
    }
}
