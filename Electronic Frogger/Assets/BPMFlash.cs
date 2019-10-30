using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPMFlash : MonoBehaviour
{
    float timer = 0;
    int BPM = 100;
    float BPS;
    Renderer renderer;
    public Material LightBarMaterial;
    private void Start()
    {
        //BPM = GameManager.GetGameManager.BPM;
        BPS = BPM / 60f;
        renderer = GetComponent<Renderer>();
    }

    private void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;
        if(timer > BPS)
        {
            timer -= BPS;
        }
        LightBarMaterial.color = new Color(Mathf.PingPong(timer*8, BPS), Mathf.PingPong(-timer * 8, BPS), 0);
    }

}
