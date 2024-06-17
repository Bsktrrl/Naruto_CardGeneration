using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ActionCardList", menuName = "ScriptableObjects/ActionCardList", order = 2)]
public class SO_ActionCard : ScriptableObject
{
    public List<ActionCard> actionCardList;
}

[System.Serializable]
public class ActionCard
{
    public string name;
    public CardType cardType;
    public ActionCardTypes type;
    public bool isInHiddenDeck;
    public Sprite image;
    [TextArea(5, 8)] public string description;
    public float textSize;

    public int cost;

    public bool fireBlock;
    public string strength;
}