using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateNode : MonoBehaviour
{
    public float speed;
    public Vector3 moveVec;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("movevec: "+ moveVec.ToString());
        transform.Translate(moveVec * speed);
    }
}
