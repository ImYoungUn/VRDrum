using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitCheck : MonoBehaviour
{

    public static bool nodeHit = false;
    public GameObject particleEffect;
    public ParticleSystem effect;

    // Start is called before the first frame update
    void Start()
    {
        effect = particleEffect.GetComponent<ParticleSystem>();
        effect.Stop();
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
            effect.Emit(1);
            nodeHit = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
        if (other.gameObject.CompareTag("note") && this.CompareTag("dest"))
        {
            Destroy(other.gameObject);
            nodeHit = false;
        }
    }
}
