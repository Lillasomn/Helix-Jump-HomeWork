using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float Speed;
    public Rigidbody Rigidbody;
    public Game Game;
    //public platform CurrentPlatform;
    
    public void Bounce()
    {
        Rigidbody.velocity = new Vector3(0, Speed, 0);
    }

    internal void Win()
    {
        Game.Winned();
        Rigidbody.velocity = Vector3.zero;
    }

    public void Rotten()
    {
        Game.Rotten();
        Rigidbody.velocity = Vector3.zero;
    }
}
