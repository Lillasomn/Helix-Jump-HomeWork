using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
   public enum State 
    { 
    Playing,
    Won,
    Rotten
    }

    public State CurrentState { get; private set; }

    public void Rotten()
    {
        //if (CurrentState != State.Playing) return;
        //CurrentState = State.Rotten;
        //Controls.enabled = false;
        //ReloadLvl();
    }

    internal void Winned()
    {
        //if (CurrentState != State.Playing) return;
        //CurrentState = State.Won;
        //Controls.enabled = false;
        //LvlIndex++;
        //ReloadLvl()
    }

    public int LvlIndex 
    {
        get => PlayerPrefs.GetInt(LvlIndexKey, 0);
        private set 
        {
            PlayerPrefs.SetInt(LvlIndexKey, value);
            PlayerPrefs.Save();
        }
    }

    private const string LvlIndexKey = "LvlIndex";
    private void ReloadLvl()
    {
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
