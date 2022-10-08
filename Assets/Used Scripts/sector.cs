using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sector : MonoBehaviour
{
    public bool NotRotten = true;
    public Material Normal;
    public Material Rotten;

    private void Awake()
    {
        GetComponent<Renderer>().sharedMaterial = NotRotten ? Normal : Rotten;
    }
    //private void OnValidate()
    //{
    //    Awake();
    //}

    private void OnCollisionEnter(Collision collision)
    {
        if (!NotRotten)

        {
            FindObjectOfType<plrcntr>().Rottenfruit();
            
            GameManager.singleton.RestartLvl();
        }

       
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (!collision.collider.TryGetComponent(out player player)) return;

    //    Vector3 normal = -collision.contacts[0].normal.normalized;
    //    float dot = Vector3.Dot(normal, Vector3.up);

    //    if (dot < 0.5) return;

    //    if (NotRotten)
    //        player.Bounce();
    //    else player.Rotten();
    //}

}
