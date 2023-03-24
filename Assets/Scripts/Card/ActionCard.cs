using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ActionCard
{
    public string name;
    public CardType cardType;
    public ActionCardTypes type;
    public Sprite image;
    [TextArea(3, 5)] public string description;
    public float textSize;

    public int cost;

    public bool fireBlock;
    public string strength;
}
