using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ClanSpecialtyCard
{
    public string name;

    public CardType cardType;
    public Clan clan;
    public int cost;

    public Sprite image;
    [TextArea(3, 5)] public string description;
    public float textSize;
}
