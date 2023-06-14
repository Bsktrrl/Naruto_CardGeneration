using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EventCardList", menuName = "ScriptableObjects/EventCardList", order = 3)]
public class SO_Event : ScriptableObject
{
    public List<EventCard> eventCardList;
}
