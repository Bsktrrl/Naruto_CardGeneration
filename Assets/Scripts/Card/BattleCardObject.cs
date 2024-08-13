using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleCardObject : MonoBehaviour
{
    [Header("Design")]
    public Image outerFrame;
    public Image background_Image;

    public Image over_Circle;
    public Image over_Field;
    public Image over_Frame;
    public Image under_Circle;
    public Image under_Field;
    public Image under_Frame;

    [Header("Character")]
    public Image characterImage;

    [Header("Info Box")]
    public Image box_Frame;
    public Image box_Background;
    public TextMeshProUGUI name_Text;
    public TextMeshProUGUI loreInfo_Text;
    public Image landOrigins_Image;

    public GameObject effectText_Parent;
    public GameObject effectTextIcon_Parent;
    public GameObject effectIcon_Parent;

    //public GameObject states_Parent;
    //public List<GameObject> states_Image;

    public List<GameObject> effectIcons;
    public Image tier_Image;
    //public Image guard_Image;

    [Header("Value")]
    public Image Taijutsu_Border_Image;
    public Image Taijutsu_Border_BG;
    public TextMeshProUGUI taijutsuValue_Text;
    public Image Ninjutsu_Border_Image;
    public Image Ninjutsu_Border_BG;
    public TextMeshProUGUI ninjutsuValue_Text;
    public Image Genjutsu_Border_Image;
    public Image Genjutsu_Border_BG;
    public TextMeshProUGUI genjutsuValue_Text;

    [Header("Heads")]
    public GameObject headParent;
    public Image head_Frame;
    public TextMeshProUGUI head_Amount;

    [Header("Tailed Beast War")]
    public GameObject focusArea_Parent;
    public Image focusArea_Frame;
    public Image focusArea_Image;

    public Sprite focus_None;

    public Sprite focus_ActionCards;
    public Sprite focus_AwakeningCards;
    public Sprite focus_BattleCards;
    public Sprite focus_BattleCards_All;
    public Sprite focus_EventCards;
    public Sprite focus_Ally_Rare;
    public Sprite focus_Ally_Epic;
    public Sprite focus_Ally_Legendary;
    public Sprite focus_Ally_RareEpic;
    public Sprite focus_Ally_RareLegendary;
    public Sprite focus_Ally_EpicLegendary;
    public Sprite focus_Ally_All;

    public Sprite focus_Effect_Poison;
    public Sprite focus_Effect_Paralyse;
    public Sprite focus_Effect_Illusion;
    public Sprite focus_Effect_Freeze;
    public Sprite focus_Effect_Chain;
    public Sprite focus_Effect_Substitution;
    public Sprite focus_Effect_All;
    public Sprite focus_Effect_All_MinusChain;
    public Sprite Effect_All_MinusSubstitution;
    public Sprite Effect_All_MinusChain_and_Substitution;
    public Sprite focus_Effect_Paralyse_and_Illusion;
    public Sprite focus_Effect_Freeze_and_Paralyze;

    public Sprite focus_Merged_Coin_and_Illusion;

    public Sprite focus_Coin;

    public Sprite focus_TailedBeast;
    public Sprite focus_TailedBeastBuff;

    public Sprite focus_Dominance_UP;
    public Sprite focus_Dominance_DOWN;
    public Sprite focus_Dominance_UpDown;
    public Sprite focus_Dominance_Weights;
    public Sprite focus_Dominance_TieBreaker;
    public Sprite focus_Dominance_UnitStrength;
    public Sprite focus_Dominance_Recruitment;
    public Sprite focus_Dominance_Payment;
    public Sprite focus_Dominance_HandLimit;

    public Sprite focus_Heal;
    public Sprite focus_HealBlock;

    public Sprite focus_Skull;
    public Sprite focus_Sand;
    public Sprite focus_Skull_Sand;

    public Sprite focus_Reroll;

    public Sprite focus_War;
    public Sprite focus_Battle;
    public Sprite focus_BattlePoint;
    public Sprite focus_CombatStrength;
    public Sprite focus_Effect;
    public Sprite focus_Resources;
    public Sprite focus_Effect_And_Resources;
    public Sprite focus_Support;

    //Detailed
    public Sprite focus_ClanCards_All;
    public Sprite focus_ClanCards_Akatsuki;
    public Sprite focus_ClanCards_Hyuga;
    public Sprite focus_ClanCards_Otsutsuki;
    public Sprite focus_ClanCards_Senju;
    public Sprite focus_ClanCards_Uchiha;
    public Sprite focus_ClanCards_Uzumaki;
    public Sprite focus_ClanCards_Kara;

    public Sprite focus_Units;
    public Sprite focus_Boats;

    public Sprite focus_Immune;

    public Sprite focus_FieldMarker;

    [Header("Heal")]
    public GameObject healParent;
    public GameObject healBlockParent;
    public Image heal_Image;
    public Image healBlock_Image;

    [Header("Chakra Natures")]
    public GameObject chakraNature_Fire;
    public GameObject chakraNature_Wind;
    public GameObject chakraNature_Lightning;
    public GameObject chakraNature_Water;
    public GameObject chakraNature_Earth;

    [Header("Resources")]
    public List<GameObject> resources_Image;

    [Header("Card info")]
    public Image setImage;
    public TextMeshProUGUI infoText;
}
