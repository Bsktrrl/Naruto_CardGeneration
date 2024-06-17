using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.ComponentModel;

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

    [Header("Focus Area")]
    public FocusArea focusArea;

    [Header("Tier")]
    public Tier tier;

    [Header("Chakra Natures")]
    public bool fire;
    public bool wind;
    public bool lightning;
    public bool earth;
    public bool water;

    [Header("Effect")]
    [TextArea(8, 15)] public string effectText;
    //public float textSize;
    public List<EffectIcon> effectIcon = new List<EffectIcon>() { EffectIcon.None, EffectIcon.None, EffectIcon.None};

    [Header("Resources")]
    public List<Resource> resources = new List<Resource>() {null, null, null, null};
}

public enum FocusArea
{
    None,

    //Cards
    [Description("Cards")][InspectorName("Cards/Action Cards")] ActionCards,
    [Description("Cards")][InspectorName("Cards/Clan Cards")] ClanCards,
    [Description("Cards")][InspectorName("Cards/Awakening Cards")] AwakeningCards,
    [Description("Cards")][InspectorName("Cards/Battle Cards")] BattleCards,
    [Description("Cards")][InspectorName("Cards/Event Cards")] EventCards,

    //Effect Token
    [Description("Effect Token")][InspectorName("Effect Token/Poison")] Effect_Poison,
    [Description("Effect Token")][InspectorName("Effect Token/Paralyse")] Effect_Paralyse,
    [Description("Effect Token")][InspectorName("Effect Token/Illusion")] Effect_Illusion,
    [Description("Effect Token")][InspectorName("Effect Token/Freeze")] Effect_Freeze,
    [Description("Effect Token")][InspectorName("Effect Token/Chain")] Effect_Chain,
    [Description("Effect Token")][InspectorName("Effect Token/Substitution")] Effect_Substitution,
    [Description("Effect Token")][InspectorName("Effect Token/All")] Effect_All,
    [Description("Effect Token")][InspectorName("Effect Token/All - Chain")] Effect_All_MinusChain,
    [Description("Effect Token")][InspectorName("Effect Token/All - Substitution")] Effect_All_MinusSubstitution,
    [Description("Effect Token")][InspectorName("Effect Token/All - Chain and Substitution")] Effect_All_MinusChain_and_Substitution,

    //Coin
    Coin,

    //Tailed Beast
    [Description("Tailed Beast")][InspectorName("Tailed Beast/Tailed Beast")] TailedBeast,
    [Description("Tailed Beast")][InspectorName("Tailed Beast/Tailed Beast Buff")] TailedBeastBuff,

    //Units
    [Description("Units")][InspectorName("Units/Units")] Units,
    [Description("Units")][InspectorName("Units/Boat")] Boats,

    //Dominance Board
    [Description("Dominance Board")][InspectorName("Dominance Board/Up")] Dominance_UP,
    [Description("Dominance Board")][InspectorName("Dominance Board/Down")] Dominance_DOWN,

    //Heal
    [Description("Heal")][InspectorName("Heal/Heal")] Heal,
    [Description("Heal")][InspectorName("Heal/Heal Block")] HealBlock,

    //Effect Icons
    [Description("Effect Icons")][InspectorName("Effect Icons/Skull")] Skull,
    [Description("Effect Icons")][InspectorName("Effect Icons/Sand")] Sand,
    [Description("Effect Icons")][InspectorName("Effect Icons/Skull and Sand")] Skull_Sand,

    //Reroll
    Reroll,

    //War
    [Description("War")][InspectorName("War/War")] War,
    [Description("War")][InspectorName("War/Battle")] Battle,
    [Description("War")][InspectorName("War/Battle Point")] BattlePoint,
    [Description("War")][InspectorName("War/Combat Strength")] CombatStrength,
    [Description("War")][InspectorName("War/Effect")] Effect,
    [Description("War")][InspectorName("War/Resources")] Resources,
    [Description("War")][InspectorName("War/Effect and Resources")] Effect_And_Resources,
    [Description("War")][InspectorName("War/Support")] Support,

    //Immune
    Immune,

    //Ally Cards
    [Description("Cards")][InspectorName("Cards/Ally/Rare")] Ally_Rare,
    [Description("Cards")][InspectorName("Cards/Ally/Epic")] Ally_Epic,
    [Description("Cards")][InspectorName("Cards/Ally/Legendary")] Ally_Legendary,

    [Description("Cards")][InspectorName("Cards/Ally/Rare and Epic")] Ally_RareEpic,
    [Description("Cards")][InspectorName("Cards/Ally/Rare and Legendary")] Ally_RareLegendary,

    [Description("Cards")][InspectorName("Cards/Ally/Epic and Legendary")] Ally_EpicLegendary,

    [Description("Cards")][InspectorName("Cards/Ally/All")] Ally_All,

    //Dominance
    [Description("Dominance Board")][InspectorName("Dominance Board/Up & Down")] Dominance_UpDown,
    [Description("Dominance Board")][InspectorName("Dominance Board/Tracks/Weights")] Dominance_Weights,
    [Description("Dominance Board")][InspectorName("Dominance Board/Tracks/Tie Breaker")] Dominance_TieBreaker,
    [Description("Dominance Board")][InspectorName("Dominance Board/Tracks/Unit Strength")] Dominance_UnitStrength,
    [Description("Dominance Board")][InspectorName("Dominance Board/Tracks/Recruitment")] Dominance_Recruitment,
    [Description("Dominance Board")][InspectorName("Dominance Board/Tracks/Payment")] Dominance_Payment,
    [Description("Dominance Board")][InspectorName("Dominance Board/Tracks/Hand Limit")] Dominance_HandLimit,

    [Description("Cards")][InspectorName("Cards/Battle Cards - All")] BattleCards_All,

    [Description("Effect Token")][InspectorName("Effect Token/Paralyse and Illusion")] Effect_Paralyse_And_Illusion,
    [Description("Effect Token")][InspectorName("Effect Token/Freeze and Paralyse")] Effect_Freeze_and_Paralyze,
}