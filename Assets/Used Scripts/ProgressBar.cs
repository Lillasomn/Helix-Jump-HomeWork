using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Rigidbody player;
    //public Player player;
    public Transform WinSector;
    //public Scrollbar slider;
    public Slider slider;
    private float startY;
    private float minY;

    private void Start()
    {
        startY = player.transform.position.y;
    }

    private void Update()
    {
        //minY = Mathf.Min(minY, player.transform.position.y);
        float currY = player.transform.position.y;
        float winY = WinSector.position.y;
        float t = Mathf.InverseLerp(startY, winY, currY);
        slider.value = t;
    }
}
