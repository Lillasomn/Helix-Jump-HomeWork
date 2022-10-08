using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Level
{
    [Range(1, 11)]
    public int partCount = 10;

    [Range(0, 11)]
    public int RotpartCount = 1;
}

[CreateAssetMenu(fileName = "New Stage")]

//[CreateAssetMenu(fileName = "New Stage", menuName = "New Stage", order = 1)]
//public class MyScriptableObjectClass : ScriptableObject
//{
//    public string objectName = "New Stage";
//    public bool colorIsRandom = false;
//    public Color thisColor = Color.white;
//    public Vector3[] spawnPoints;
//}

public class Stage : ScriptableObject
{
    //public Color stageBGcolor = Color.blue;
    //public Color stageLvlPartcolor = Color.blue;

    public List<Level> levels = new List<Level>();
}
