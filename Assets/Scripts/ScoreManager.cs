using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private static int score = 0;
    private GameObject scoreText; 

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("ScoreText");

        if (scoreText == null)
        {
            Debug.LogError("Could not find GameObject: scoreText");
        }
        else
        {
            scoreText.GetComponent<Text>().text = "score: " + score;
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<Text>().text = "score: " + score;
    }

    public static void IncreaseScore(int points)
    {
        score += points;
    }
}
