using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitCheck2 : MonoBehaviour
{

    public static bool nodeHit = false;
    public GameObject particleEffect;
    //private ParticleSystem effect;
    private GameObject neweffect;
    private double TimeElapse;
    private double createTime;
    private bool effectCreate = false;

    // Start is called before the first frame update
    void Start()
    {
        TimeElapse = 0;
    }

    // Update is called once per frame
    void Update()
    {
        TimeElapse += Time.deltaTime;
        Debug.Log("hitcheck2 " + (TimeElapse - createTime).ToString());
        if (effectCreate)
        {
            if (TimeElapse - createTime > 0.3f)
            {
                Destroy(neweffect);
                effectCreate = false;
            }
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("note") && this.CompareTag("dest"))
        {

            //Instantiate(explosion, other.transform.position, Quaternion.identity);

            nodeHit = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.CompareTag("note") && this.CompareTag("dest"))
        {
            neweffect = Instantiate(particleEffect, other.transform.position, other.transform.rotation);
            effectCreate = true;
            createTime = TimeElapse;
            Destroy(other.gameObject);
            nodeHit = false;
        }
    }
}