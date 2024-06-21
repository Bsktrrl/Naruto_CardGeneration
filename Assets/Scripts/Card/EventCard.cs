using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EventCard
{
    public string name;
    public Sprite image;
    public bool isLastRound;
    [TextArea(8, 5)] public string description;
}
