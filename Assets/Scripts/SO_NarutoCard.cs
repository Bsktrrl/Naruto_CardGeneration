using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardList", menuName = "ScriptableObjects/CardList", order = 1)]
public class SO_NarutoCard : ScriptableObject
{
    public static List<Card> cardList;
}
