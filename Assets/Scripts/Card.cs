using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

[System.Serializable]
public class Card
{
    [System.Serializable]
    public class ChakraNature
    {
        public List<ChakraNatures> natureType = new List<ChakraNatures>() {ChakraNatures.Fire, ChakraNatures.Wind, ChakraNatures.Lightning, ChakraNatures.Earth, ChakraNatures.Water};
        public List<int> natureValue = new List<int>() {0, 0, 0, 0, 0};
    }

    [System.Serializable]
    public class Resource
    {
        public Resources resources;
        public int amount;
    }


    //--------------------


    [Header("Parameters")]
    public int ID;

    public Clan clan;
    public string name;
    public string role;
    public landOrigins landOrigins;

    public int value;
    public ChakraNature chakraNatures;

    public int headAmount;

    public Heal heal;
    public List<State> state;
    public List<Resource> resources;

    public string effect;
}