using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNode : MonoBehaviour
{
    public GameObject node;
    public Transform NodeSpawnPos;
    public Transform NodeEndPos;
    public float spawnrate;

    float currTime;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        currTime += Time.deltaTime;
        if (currTime > spawnrate)
        {
            
            Vector3 nodePos = NodeSpawnPos.position;
            Vector3 move = NodeEndPos.position - NodeSpawnPos.position;
            //Vector3 nodePos = new Vector3(-1.71F, 0.67569F, 2.8F);
            GameObject temp_node = Instantiate(node, nodePos, Quaternion.identity);
            temp_node.GetComponent<TranslateNode>().moveVec = move;

            currTime = 0;
        }
    }
}