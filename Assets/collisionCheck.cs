using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionCheck : MonoBehaviour
{
    //public ParticleSystem explosion;
    public static bool nodeHit = false;
    //public string collisionTag;
    
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
        if(other.gameObject.CompareTag("node"))
        {
            //Instantiate(explosion, other.transform.position, Quaternion.identity);
            nodeHit = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
        nodeHit = false;
    }
}
