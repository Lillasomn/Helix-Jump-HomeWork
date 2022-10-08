using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helixcntr : MonoBehaviour
{
    private Vector2 lastTapPos;
    private Vector3 startRotation;

    public Transform TopPl;
    public Transform WinPl;
    public GameObject LvlPrefab;

    public List<Stage> allStages = new List<Stage>();
    private float helixDistance;
    private List<GameObject> Lvls = new List<GameObject>();
    void Awake()
    {
        startRotation = transform.localEulerAngles;
        helixDistance = TopPl.localPosition.y - (WinPl.localPosition.y + 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        { 
            Vector2 currTapPos = Input.mousePosition;
            if (lastTapPos==Vector2.zero) { lastTapPos = currTapPos; }

            float delta = lastTapPos.x - currTapPos.x;
            lastTapPos = currTapPos;

            transform.Rotate(Vector3.up * delta);
        }

        if (Input.GetMouseButtonUp(0)) { lastTapPos = Vector2.zero; }
    }

    public void LoadStage (int StageNumber)
    {
        Stage stage = allStages[Mathf.Clamp(StageNumber, 0, allStages.Count - 1)];
    }
}
