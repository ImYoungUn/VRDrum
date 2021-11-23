using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateEffect : MonoBehaviour
{
    public ParticleSystem explosion;
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
        //Debug.Log("colision");
        if (other.tag == "DrumStickHead")
        {
            if(collisionCheck.nodeHit)
            {
                Instantiate(explosion, other.transform.position, Quaternion.identity);
            }
        }
    }
}
