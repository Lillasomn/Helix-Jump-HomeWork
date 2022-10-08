﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracntr : MonoBehaviour
{
    public plrcntr target;
    private float offset;
    void Awake()
    {
        offset = transform.position.y - target.transform.position.y;
    }

    void Update()
    {
        Vector3 currentPos = transform.position;
        currentPos.y = target.transform.position.y+offset;
        transform.position = currentPos;
    }
}
