using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{

    public static int score = 0;
    public TextMesh scoreText;
    public double TimeElapse = 0;

    public GameObject[] particle = new GameObject[6];
    private ParticleSystem[] effect = new ParticleSystem[6];

    // Start is called before the first frame update
    void Start()
    {
        for(int i =0; i < 6; i++)
        {
            effect[i] = particle[i].GetComponent<ParticleSystem>();
            effect[i].Stop();
        }
        //scoreText.Text = "fffffff";
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        TimeElapse += Time.deltaTime;

        if(TimeElapse > 6)
        {
            for(int i = 0; i < 6; i++)
            {
                effect[i].Play();
            }
        }
    }
}
