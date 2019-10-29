using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPMCalculator : MonoBehaviour
{
    public float timer = 0f;
    public float BPM;
    public bool timerStart = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (timerStart)
        {
            timer += Time.fixedDeltaTime;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!timerStart)
        {
            timerStart = true;
        }
        else
        {
            BPM = timer * 60;
            timer = 0; 
        }

    }
}
