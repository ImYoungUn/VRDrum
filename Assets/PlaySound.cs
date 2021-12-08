using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {

    private AudioSource source;
    public bool playOnButtonPress = false;
    public string button;
    public GameObject particleEffect;
    private ParticleSystem effect;
    private float collisionTime1;
    private float collisionTime2;
    private float collisionTime3;
    private float collisionTime4;
    private float collisionTime5;

    private bool isColid;
    private double colidGap;


    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();
        effect = particleEffect.GetComponent<ParticleSystem>();
        effect.Stop();
        isColid = false;
        colidGap = 0;

    }

    private void Update()
    {
        
        if(playOnButtonPress)
        {
            CheckButtonPress(); 
        }
        
        colidGap += Time.deltaTime;
        if(colidGap > 0.05)
        {
            isColid = false;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("colision");
        if (other.tag == "DrumStickHead" && !isColid)
        {
            //Debug.Log("colision with drumstick");
            isColid = true;
            colidGap = 0;
            source.volume = other.gameObject.GetComponent<TrackSpeed>().speed;
            //source.volume = 1f;
            ActivateSound();
            effect.Emit(1);
            if (hitCheck1.nodeHit)
            {
                
                //Debug.Log("sex1");
                MainController.score++;
                hitCheck1.nodeHit = false;
            }
            if (hitCheck2.nodeHit)
            {
                //Debug.Log("sex2");
                MainController.score++;
                hitCheck2.nodeHit = false;
            }
            if (hitCheck3.nodeHit)
            {
                //Debug.Log("sex3");
                MainController.score++;
                hitCheck3.nodeHit = false;
            }
            if (hitCheck4.nodeHit)
            {
                //Debug.Log("sex4");
                MainController.score++;
                hitCheck4.nodeHit = false;
            }
            if (hitCheck5.nodeHit)
            {
                //Debug.Log("sex5");
                MainController.score++;
                hitCheck5.nodeHit = false;
            }
        }
        Debug.Log("score: " + MainController.score);
    }

    private void ActivateSound()
    {
        source.pitch = Random.Range(0.8f, 1.2f);
        source.Play();
    }

    void CheckButtonPress()
    {
//        switch (button)
//        {
//            case "A":
//                if (OVRInput.GetDown(OVRInput.RawButton.A)) ActivateSound();
//                break;
//            case "B":
//                if (OVRInput.GetDown(OVRInput.RawButton.B)) ActivateSound();
//                break;
//        }
    }

}
