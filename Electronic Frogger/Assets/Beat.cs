using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Note { Full, Half, Quarter, Eigth, Sixteenth}
public class Beat : MonoBehaviour
{
    public Note note;
    public int column;
    public bool doted;
    public float space
    {
        get {
            if (!doted)
            switch (note)
            {
                
                case Note.Full:
                    return 4f;
                case Note.Half:
                    return 2f;
                case Note.Quarter:
                    return 1f;
                case Note.Eigth:
                    return .5f;
                case Note.Sixteenth:
                    return .25f;
                default:
                    return 0f;
            }else
                switch (note)
                {

                    case Note.Full:
                        return 6f;
                    case Note.Half:
                        return 3f;
                    case Note.Quarter:
                        return 1.5f;
                    case Note.Eigth:
                        return .75f;
                    case Note.Sixteenth:
                        return .375f;
                    default:
                        return 0f;
                }
        }
    }
    public Beat(int columnNum, Note noteType, bool dot = false)
    {
        note = noteType;
        column = columnNum;
        doted = dot;
    }
}
