using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ClanSpecialtyCardList", menuName = "ScriptableObjects/ClanSpecialtyCardList", order = 3)]
public class SO_ClanSpecialtyCard : ScriptableObject
{
    public List<ClanSpecialtyCard> clanSpecialtyCardList;
}

[System.Serializable]
public class ClanSpecialtyCard
{
    [Header("General")]
    public string name;

    public CardType cardType;
    public Clan clan;

    [Header("Versions")]
    public bool version_Passive_A;
    public bool version_Passive_B;
    public bool version_Specialty_A;
    public bool version_Specialty_B;

    [Header("Cost")]
    public int cost;

    [Header("Descriptions")]
    public Sprite image;
    [TextArea(10, 10)] public string description;
    public float textSize;
}