using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BattleCard
{
    [System.Serializable]
    public class ChakraNature
    {
        //public List<ChakraNatures> natureType = new List<ChakraNatures>() {ChakraNatures.Fire, ChakraNatures.Wind, ChakraNatures.Lightning, ChakraNatures.Earth, ChakraNatures.Water};
        public List<int> natureValue = new List<int>() {0, 0, 0, 0, 0};
    }

    [System.Serializable]
    public class Resource
    {
        public Resources resources;
        public int amount;
    }


    //--------------------


    [Header("Name")]
    public string name;
    public string loreInfo;
    public int index;
    public setNames set;

    [Header("Character")]
    public Sprite characterSprite;

    [Header("Origin")]
    public CardType cardType;
    public Clan clan;
    public landOrigins landOrigins;

    [Header("Values")]
    public int TaijutsuValue;
    public int NinjutsuValue;
    public int GenjutsuValue;

    [Header("Heal")]
    public Heal heal;

    [Header("Tailed Beast Amount")]
    public int headAmount;

    [Header("Tier")]
    public Tier tier;

    [Header("Chakra Natures")]
    public bool fire;
    public bool wind;
    public bool lightning;
    public bool earth;
    public bool water;

    [Header("Effect")]
    [TextArea(7, 6)] public string effectText;
    //public float textSize;
    public List<EffectIcon> effectIcon = new List<EffectIcon>() { EffectIcon.None, EffectIcon.None, EffectIcon.None};

    [Header("Resources")]
    public List<Resource> resources = new List<Resource>() {null, null, null, null};
}