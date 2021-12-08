using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{

    public static int score = 0;
    public TextMesh scoreText;
    public double TimeElapse = 0;

    public GameObject[] light = new GameObject[6];
    public GameObject[] star = new GameObject[6];
    public GameObject[] smoke = new GameObject[2];


    private ParticleSystem[] lightEffect = new ParticleSystem[6];
    private ParticleSystem[] starEffect = new ParticleSystem[6];
    private ParticleSystem[] smokeEffect = new ParticleSystem[2];

    private bool effectTrigger = false;


    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 6; i++)
        {
            lightEffect[i] = light[i].GetComponent<ParticleSystem>();
            starEffect[i] = star[i].GetComponent<ParticleSystem>();
            
            lightEffect[i].Stop();
            starEffect[i].Stop();
            
        }
        for(int i = 0; i < 2; i++)
        {
            smokeEffect[i] = smoke[i].GetComponent<ParticleSystem>();
            smokeEffect[i].Stop();
        }
        //scoreText.Text = "fffffff";
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        TimeElapse += Time.deltaTime;

        if(TimeElapse > 47.0f && !effectTrigger)
        {
            for(int i = 0; i < 6; i++)
            {
                lightEffect[i].Play();
                starEffect[i].Play();
            }
            for(int i =0; i < 2; i++)
            {
                smokeEffect[i].Play();
            }
            effectTrigger = true;
        }
    }
}
