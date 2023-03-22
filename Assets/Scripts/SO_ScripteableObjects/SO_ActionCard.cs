using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ActionCardList", menuName = "ScriptableObjects/ActionCardList", order = 2)]
public class SO_ActionCard : ScriptableObject
{
    public List<ActionCard> actionCardList;
}
