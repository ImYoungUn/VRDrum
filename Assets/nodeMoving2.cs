using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nodeMoving2 : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float z = 1.73205080757F;
        transform.Translate(new Vector3(-1, 0, z) * speed);
    }
}
