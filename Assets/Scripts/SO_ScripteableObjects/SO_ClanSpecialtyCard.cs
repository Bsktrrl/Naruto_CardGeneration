using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ClanSpecialtyCardList", menuName = "ScriptableObjects/ClanSpecialtyCardList", order = 3)]
public class SO_ClanSpecialtyCard : ScriptableObject
{
    public List<ClanSpecialtyCard> clanSpecialtyCardList;
}
