using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int BestScore;
    public int Score;
    public string NextScene;

    public int CurrStage = 0;
    public static GameManager singleton;
    void Awake()
    {
        if (singleton == null) singleton = this;
        else if (singleton != this) Destroy(gameObject);

        if (SceneManager.GetActiveScene().name != "Lvl1")
        //{ Score = singleton.Score; }
        { Score = PlayerPrefs.GetInt("Score"); }
        else Score = 0;

        BestScore = PlayerPrefs.GetInt("BestScore");
    }

    public void NextLvl()
    {
        CurrStage++;
        FindObjectOfType<plrcntr>().ResetPlayer();

        PlayerPrefs.SetInt("Score", singleton.Score);

        if (NextScene !="")
        { SceneManager.LoadScene(NextScene); }
       
    }

    public void RestartLvl()
    {
        singleton.Score = 0;
        FindObjectOfType<plrcntr>().ResetPlayer();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AddScore (int scoreToAdd)
    {
        Score += scoreToAdd;
        if (Score> BestScore) { BestScore = Score; PlayerPrefs.SetInt("BestScore", BestScore); }
    }

}
