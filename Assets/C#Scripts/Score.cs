using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score instance;

    public Text scoreText;
    public Text highscoreText;

    int score = 0;
    int highscore = 0;

    PlayerScript script;

    private void Awake()
    {
        instance = this;
    }


    void Start()
    {
        scoreText.text = "Score: " + score.ToString();

        script = gameObject.AddComponent<PlayerScript>();
    }


    public void AddPoints()
    {
        
        score += 1;
        scoreText.text = score.ToString() + " points";

    }


    public void AddMorePoints()
    {
        score += 3;
        scoreText.text = score.ToString() + " points";
    }



    /* void SetScore()
     {
         if (script.health <= 0)
         {
             if (score > highscore);
             {
                highscoreText.text = score.ToString() + " points";
                highscore = score;
             {
         }
     }*/


    public void ResetPoints()
    {
        score = 0;
    }


    void Update()
    {
       // SetScore();

    }
}
