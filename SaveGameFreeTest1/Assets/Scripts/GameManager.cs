using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private ScoreTest scoreTest;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreTest = GetComponent<ScoreTest>();
    }

    public void OnQuitButtonClicked()
    {
        Application.Quit();
    }

    public void OnSaveButtonClicked()
    {
        this.scoreTest.SaveScore();
    }

    public void OnLoadButtonClicked()
    {
        this.scoreTest.LoadScore();
    }

    public void OnScoreButtonClicked()
    {
        this.scoreTest.AddToScore();
    }
}
