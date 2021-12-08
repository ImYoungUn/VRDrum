using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class nodeGenerator : MonoBehaviour
{
    const int NUMOFDRUM = 5;
    

    private List<Tuple<int, float>> notes = new List<Tuple<int, float>>();
    private float timeDiff;
    private int numOfNote;
    private bool isFinish;
    private float[] nx = new float[5];
    private float[] nz = new float[5];
    private float[] fx = new float[5];
    private float[] fz = new float[5];
    private AudioSource bgm;


    public GameObject[] ori = new GameObject[5];
    public float near;
    public float far;
    public float farH;
    public int level;
    public GameObject Player;


    void Start()
    {
        bgm = Player.GetComponent<AudioSource>();

        int index = 1;
        string filePath = Path.Combine(Application.dataPath, "test.txt");
        foreach (string line in System.IO.File.ReadLines(filePath))
        {
            string[] note = line.Split();
            for (int i = 0; i < note.Length; i++)
            {
                notes.Add(new Tuple<int, float>(index, float.Parse(note[i]) * 0.284f));
            }
            index++;
        }

        notes.Sort((a, b) => a.Item2 < b.Item2 ? -1 : 1);

        farH = farH + 0.5f;

        for (int i = 0, angle = 40; i < NUMOFDRUM; i++, angle -= 20)
        {
            float radian = (float)(Math.PI * angle / 180);
            nx[i] = (float)(-Math.Sin(radian)) * near;
            nz[i] = (float)(Math.Cos(radian)) * near;
            GameObject obj = Instantiate(ori[i], new Vector3(nx[i], 0.5f, nz[i]), ori[i].transform.rotation);
            obj.transform.localScale += new Vector3(0, 0, 0.2f);
            obj.tag = "dest";

            fx[i] = (float)(-Math.Sin(radian)) * far;
            fz[i] = (float)(Math.Cos(radian)) * far;
            obj = Instantiate(ori[i], new Vector3(fx[i], farH, fz[i]), ori[i].transform.rotation);
            obj.tag = "start";
        }

        timeDiff = 0.0f;
        numOfNote = 0;
        isFinish = false;

    }

    void Update()
    {
        timeDiff += Time.deltaTime;
        if (!isFinish && timeDiff > notes[numOfNote].Item2)
        {
            int drumIndex = notes[numOfNote].Item1 - 1;
            GameObject obj = Instantiate(ori[drumIndex], new Vector3(fx[drumIndex], farH, fz[drumIndex]), ori[drumIndex].transform.rotation);
            obj.tag = "note";
    
            Rigidbody noteRb = obj.GetComponent<Rigidbody>();
            noteRb.velocity = new Vector3(nx[drumIndex], 0.6f, nz[drumIndex]) * -level;

            numOfNote++;
        }

        if (numOfNote > notes.Count - 1)
        {
            isFinish = true;
        }
    }
}