using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Card
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


    [Header("ID")]
    public int ID;

    [Header("Origin")]
    public Clan clan;
    public landOrigins landOrigins;

    [Header("Name")]
    public string name;
    public string loreInfo;

    [Header("Values")]
    public int TaijutsuValue;
    public int NinjutsuValue;
    public int GenjutsuValue;

    [Header("Chakra Natures")]
    public List<int> chakraNatureValue = new List<int>() { 0, 0, 0, 0, 0 };

    [Header("Tailed Beast Head")]
    public int headAmount;

    [Header("Heal")]
    public Heal heal;

    [Header("Effect")]
    public List<State> effectState;
    [TextArea(3, 5)] public string effectText;
    public Tier tier;

    [Header("Resources")]
    public List<Resource> resources;
}