using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum CardType
{
    None,

    BattleCard,
    ActionCard,
    ClanSpecialty,
    Event
}
public enum Clan
{
    None,

    Akatsuki,
    Hyuga,
    Otsutsuki,
    Senju,
    Uchiha,
    Uzumaki,

    Ally,
    Ally_Rare,
    Ally_Epic,
    Ally_Legendary
}
public enum ChakraNatures
{
    None,

    Fire,
    Wind,
    Lightning,
    Earth,
    Water
}
public enum Heal
{
    None,

    Heal,
    HealBlock
}
public enum State
{
    None,

    Immediately,
    AfterTheWar,
    ifWin,
    ifLose,
    ifBattleAdvantage,
    ifNotBattleAdvantage
}
public enum EffectIcon
{
    None,

    Skull,
    Shield
}
public enum Resources
{
    None,

    Boat,
    Chuunin,
    Jounin,
    Kage,

    ActionCard,
    ClanCard,

    Ally_Rare,
    Ally_Epic,
    Ally_Legendary,

    Effect_Poison,
    Effect_Paralyze,
    Effect_Illusion,
    Effect_Freeze,
    Effect_Chain,

    Influence_UP,
    Influence_DOWN,

    Coin,
    TailedBeast
}

public enum Tier
{
    None,

    Common,
    Rare,
    Epic,
    Legendary
}

public enum landOrigins
{
    None,

    ANBU,
    Cliff,
    Cloud,
    Craftsmen,
    Curtain,
    Dawn,
    Eddy,
    Fields,
    Grass,
    Hawk,
    Haze,
    HotWater,
    Iron,
    JiroIsland,
    KikaIsland,
    LandOfAncestors,
    Leaf,
    Lock,
    Mines,
    Mist,
    Moon,
    MountMyoboku,
    Mountain,
    Noodles,
    Rain,
    Rice,
    River,
    Sand,
    Sea,
    Sky,
    Snow,
    Sound,
    Star,
    Stone,
    Tea,
    ThreeTunders,
    TurtleIsland,
    Vegetable,
    Waterfall,
    Wave
}

public enum ActionCards
{
    None,

    Ally_Rare,
    Ally_Epic,
    Ally_Legendary,

    ClanCard,
    Defence,
    DominanceTrack,
    Fire,
    HealingOintment,

    Piece_Boat,
    Piece_Chuunin,
    Piece_Jounin,
    Piece_Kage,

    Reroll,
    Reuse,
    Scroll,
    Support,
    Trade,
    Travel,
    Turns,
    Upgrade,
    War
}

public enum ActionCardTypes
{
    None,

    Action,
    Reaction,
    ActionReaction,
    SpecialAction
}