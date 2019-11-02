using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Measure : MonoBehaviour
{
    public List<Beat> beats;
    public  float beatsRemaining
    {
        get
        {
            float i = 4f;
            foreach (var beat in beats)
            {
                i -= beat.space;
            }
            return i;
        }
    }
    public Measure(List<Beat> SetBeats)
    {
        beats = SetBeats;
    }
}
