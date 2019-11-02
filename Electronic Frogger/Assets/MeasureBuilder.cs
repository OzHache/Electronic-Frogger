using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MeasureBuilder : MonoBehaviour
{
    public static List<Measure> Build()
    {
        List<Measure> measures = new List<Measure>(){
            //measure 1
            new Measure(SetBeats: (new List<Beat>
            {
                new Beat(11, Note.Quarter),
                new Beat(10, Note.Eigth, true),
                new Beat(9, Note.Sixteenth),
                new Beat(10, Note.Quarter),
                new Beat(9, Note.Eigth),
                new Beat(8, Note.Eigth)
            })),
            //measure 1
            new Measure(SetBeats: (new List<Beat>
            {
                new Beat(11, Note.Quarter),
                new Beat(10, Note.Eigth, true),
                new Beat(9, Note.Sixteenth),
                new Beat(10, Note.Quarter),
                new Beat(9, Note.Eigth),
                new Beat(8, Note.Eigth)
            }))

        };

        foreach (var measure in measures)
        {
            Debug.Log(measure.beatsRemaining.ToString());
        }
        return measures;
    }
}
