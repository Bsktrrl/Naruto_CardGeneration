using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDisplayManager : Singleton<CardDisplayManager>
{
    [Header("Battle Card Display")]
    public Clan clanFocus_BattleCard;
    public bool focusIcon;
    public int battleCard_Number;
    public Sprite baseSet_Icon;
    public string endYear = "2024";
    public string companyName = "AM Games";

    [Header("Clan Specialty Display")]
    public Clan clanFocus_ClanSpecialty;
    public int clanSpecialtyCard_Number;

    [Header("Action Card Display")]
    public int actionCard_Number;

    [Header("Event Card Display")]
    public int eventCard_Number;
}
