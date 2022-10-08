using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class LvlGen : MonoBehaviour
{
    public GameObject[] PlatfPrefs;
    public GameObject FirstPlatform;
    public int MinPlatfs;
    public int MaxPlatfs;
    public float DistanceBPlatfs;
    public Transform WinPlatform;
    public Transform Center;
    public Game Game;
    private void Awake()
    {
        //int platfsCount = Random.Range(MinPlatfs, MaxPlatfs+1);
        //for (int i=0;i<platfsCount;i++)
        {
            //int LvlIndex = Game.LvlIndex;
            //Random random = new Random(LvlIndex);
            //int platfsCount = RandRange(random, MinPlatfs, MaxPlatfs + 1);
            //int prefindex = RandRange(random, 0, PlatfPrefs.Length);
            //GameObject Platfpref = i == 0 ? FirstPlatform | PlatfPrefs [prefindex];
            //GameObject platform = Instantiate(Platfpref, transform);
            //platform.transform.localPosition = new Vector3(0, - DistanceBPlatfs * i, 0);
            //if (i > 0)
            //platform.transform.localRotation = Quaternion.Euler(0, RandRange(random, 0, 360f), 0);
        }
        //last win platform position
        //WinPlatform.localPosition = new Vector3(0, -DistanceBPlatfs * platfsCount, 0);
        //changes scale of central cylinder
        //Center.localScale = new Vector3(1, platfsCount * DistanceBPlatfs, 1);
        //make platf templates in assets/prefab
    }

    private int RandRange(Random random,int min, int maxexl)
    {
        int number = random.Next();
        int lenghth = maxexl - min;
        number %= lenghth;
        return min + number;
    }

    private float RandRange(Random random, float min, float max)
    {
        float t = (float)random.NextDouble();
        return Mathf.Lerp(min, max, t);
    }
}
