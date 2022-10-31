using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BayatGames.SaveGameFree;


public class ScoreTest : MonoBehaviour
{
    private Score score;
    public Text scoreText;
    public string identifier = "scoreSaveMV";

    // Start is called before the first frame update
    void Start()
    {
        score = new Score();
        LoadScore();
    }

    private void DisplayScore()
    {
        scoreText.text = "Score: " + score.scorePoints;
    }

    public void SaveScore()
    {
        Debug.Log("Saving score...");
        SaveGame.Save<int>(this.identifier, this.score.scorePoints);
    }

    public void LoadScore()
    {
        Debug.Log("Loading score...");
        int scorePoints = SaveGame.Load<int>(identifier);
        Debug.Log("Loaded score point: " + scorePoints);
        this.score.scorePoints = scorePoints;
        DisplayScore();
    }

    public void AddToScore()
    {
        score.scorePoints++;
        DisplayScore();
    }
}
