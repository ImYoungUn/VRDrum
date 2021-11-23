using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nodeMoving : MonoBehaviour
{
    public GameObject node;
    public GameObject Drum;
    float currTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float DrumX = Drum.transform.position.x;
        float DrumY = Drum.transform.position.y;
        float DrumZ = Drum.transform.position.z;
    //    Debug.Log(DrumX);
    //    Debug.Log(DrumY);
    //    Debug.Log(DrumZ);
        currTime += Time.deltaTime;
        if(currTime > 4)
        {
            float y = 0.6756992F;
            float z = -5.19615242271F;
            Vector3 nodePos = new Vector3(DrumX+3, DrumY, DrumZ + z);
            //Vector3 nodePos = new Vector3(-1.71F, 0.67569F, 2.8F);
            GameObject temp_node = Instantiate(node, nodePos, Quaternion.identity);
            currTime = 0;
        }
    }
}
