using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plrcntr : MonoBehaviour
{
    private bool ignoreNextCollision;
    public Rigidbody RB;
    public float Impulse;
    private Vector3 startPos;

    public Material Rottenmat;
    public Material Normmat;
    public bool isRotten = false;

    public AudioSource Boom;
    public AudioSource Bounce;
    public AudioSource Rotten;

    public int CameThrough = 0;
    public bool isBigHit;
    private float Disolve = 0f;
    private float shaderValue;

    public GameObject RotSmoke;
    public GameObject HitSmoke;

    private void Awake()
    {
        startPos = transform.position;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (isBigHit)
        {
            if (!collision.transform.GetComponent<Final>());
            {
                Destroy(collision.gameObject);
                //Boom = GetComponent<AudioSource>();
                Boom.Play();
                Instantiate(HitSmoke, collision.transform.position, Quaternion.identity);
                new WaitForSeconds(2f);
            }
 
        }

        else 
        {
            RotSector rotsect = collision.transform.GetComponent<RotSector>();
            if (rotsect) rotsect.RottenPart();
        }

        if (ignoreNextCollision) return;

        //RotSector rotsect = collision.transform.GetComponent<RotSector>();
        //if (rotsect) rotsect.RottenPart();

        RB.velocity = Vector3.zero;
        RB.AddForce(Vector3.up*Impulse, ForceMode.Impulse);
        ignoreNextCollision = true;
        Invoke("AllowCollision", .2f);

        CameThrough = 0;
        isBigHit = false;

        //Bounce = GetComponent<AudioSource>();
        Bounce.Play();

        //GameManager.singleton.AddScore(1);
    }

    private void Update()
    {
        // big hit part
        if (CameThrough >= 2 && !isBigHit)
        {
            isBigHit = true;
            RB.AddForce(Vector3.down * 10, ForceMode.Impulse);
        }

        //if (isRotten) StartCoroutine(Rot());

        //if (_Disolve<0.9 && isRotten)
        //Rottenmat.SetFloat("_Disolve", Mathf.MoveTowards(Rottenmat.GetFloat("_Disolve"), 1, 100 * Time.deltaTime));
    }


    private void AllowCollision() { ignoreNextCollision = false; }

    public void ResetPlayer()
    {
        isRotten = false;
        GetComponent<Renderer>().sharedMaterial = Normmat;
        transform.position = startPos;
        Impulse = 5;
        Disolve = 0;
        StopCoroutine(Rot());
    }

    public void Rottenfruit()
    {
        Rotten.Play();
        GetComponent<Renderer>().sharedMaterial = Rottenmat;
        Impulse = 0;
        isRotten = true;
        Instantiate(RotSmoke, RB.position, Quaternion.identity);
        StartCoroutine(Rot());
    }

    IEnumerator Rot()
    {
        for (float Disolve = 0; Disolve <= 1f; Disolve += 0.1f)
        {
            yield return new WaitForSeconds(0.4f);
            Rottenmat.SetFloat("_Disolve", Disolve);
        }

    }
}
