using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cntrl : MonoBehaviour
{
    public Transform Level;
    public float Sensitivity;
    private Vector3 _prev_mouse_pos;
    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - _prev_mouse_pos;
            Level.Rotate(0, -delta.x*Sensitivity, 0);
        }
        _prev_mouse_pos = Input.mousePosition;
    }
}
