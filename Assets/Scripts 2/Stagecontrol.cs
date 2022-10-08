using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stagecontrol : MonoBehaviour
{
    public Transform TopPl;
    public Transform WinPl;
    public GameObject LvlPrefab;
    public Material Killsector;
    //public Material PlayerMat;
    private Vector3 startRot;

    public List<Stage> allStages = new List<Stage>();
    private float helixDistance;
    private List<GameObject> Lvls = new List<GameObject>();

    private void Awake()
    {
        startRot = transform.eulerAngles;
        helixDistance = TopPl.localPosition.y - WinPl.localPosition.y;
        LoadStage(0);
    }

    public void LoadStage(int StageNumber)
    {
        //Stage stage = allStages[Mathf.Clamp(StageNumber, 0, allStages.Count - 1)];
        //Camera.main.backgroundColor = allStages[StageNumber].stageBGcolor;
        //FindObjectOfType<plrcntr>().GetComponent<Renderer>().material = PlayerMat;
        transform.localEulerAngles = startRot;

        //destroy old lvls
        //foreach (GameObject gameObject in Lvls) Destroy(gameObject);
        ////build new one
        //float lvlDistance = helixDistance / stage.level.Count;
        //float spawnPosY = TopPl.localPosition.y;

        //for (int i = 0; i < stage.levels.Count; i++)
        //{
        //    spawnPosY -= lvlDistance;
        //    GameObject level = Instantiate(LvlPrefab, transform);
        //    level.transform.localPosition = new Vector3(0, spawnPosY, 0);
        //    Lvls.Add(level);

        //    // Disable parts
        //    int partsToDisable = 12 - stage.levels[i].partCount;
        //    List<GameObject> disabledParts = new List<GameObject>();

        //    while (disabledParts.Count < partsToDisable)
        //    {
        //        GameObject randomPart = level.transform.GetChild(Random.Range(0, level.transform.childCount)).gameObject;
        //        if (!disabledParts.Contains(randomPart))
        //        {
        //            randomPart.SetActive(false);
        //            disabledParts.Add(randomPart);
        //            Debug.Log("Disabled Part");
        //        }
        //    }

        //    // Rot parts
        //    List<GameObject> leftParts = new List<GameObject>();

        //    foreach (Transform t in level.transform)
        //    {
        //        t.GetComponent<Renderer>().material = Killsector;

        //        if (t.gameObject.activeInHierarchy)
        //            leftParts.Add(t.gameObject);
        //    }


        //    List<GameObject> RottenParts = new List<GameObject>();

        //    while (RottenParts.Count < stage.levels[i].RotpartCount)
        //    {

        //        GameObject randomPart = Lvls[(Random.Range(0, stage.levels[i].partCount))];

        //        if (!RottenParts.Contains(randomPart))
        //        {
        //            randomPart.gameObject.AddComponent<RotSector>();
        //            RottenParts.Add(randomPart);
        //        }

            //}
        //}

    }
}
