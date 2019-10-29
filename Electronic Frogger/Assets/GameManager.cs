using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int BPM = 140;
    public static GameManager GetGameManager;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.GetGameManager = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
