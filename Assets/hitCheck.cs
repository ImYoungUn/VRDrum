using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitCheck : MonoBehaviour
{

    public static bool nodeHit = false;

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
        if (other.gameObject.CompareTag("note"))
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
