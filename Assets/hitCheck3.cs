using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitCheck3 : MonoBehaviour
{

    public static bool nodeHit = false;
    public GameObject particleEffect;
    //private ParticleSystem effect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

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
            Instantiate(particleEffect, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            nodeHit = false;
        }
    }
}
