using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMeasure : MonoBehaviour
{
    public List<Measure> measures;
    public GameObject Prefab;
    public GameObject fly;

    
    // Start is called before the first frame update
    void Start()
    {
        measures = MeasureBuilder.Build();
        ConstructGO();
    }

    private void ConstructGO()
    {
        foreach(Measure measure in measures)
        {
            var prefab = Instantiate(Prefab, transform);
            prefab.transform.position = Vector3.down * measures.IndexOf(measure) * 4;
            foreach (var beat in measure.beats)
            {
                var note = Instantiate(fly, prefab.transform);
                note.transform.position = new Vector3(beat.column+5, -beat.space, 0);
            }
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
    

}
