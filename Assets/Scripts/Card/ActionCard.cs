using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ActionCard
{
    public string name;
    public ActionCards category;
    public ActionCardTypes type;
    [TextArea(3, 5)] public string description;

    public int cost;

    public bool fireBlock;
    public string strength;
}
