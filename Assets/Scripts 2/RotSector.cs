using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotSector : MonoBehaviour
{
    public Material Killsector;

    private void OnEnable()
    {
        GetComponent<Renderer>().sharedMaterial = Killsector;
    }

    public void RottenPart()
    {
        FindObjectOfType<plrcntr>().Rottenfruit();
        GameManager.singleton.RestartLvl();
    }

    private void OnValidate()
    {
        OnEnable();
    }
}
