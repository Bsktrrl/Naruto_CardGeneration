using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
    #region Variables
    MainManager mainManager;

    [Header("Card Display")]
    [SerializeField] Clan clanFocus_BattleCard;
    [SerializeField] int battleCard_Number;
    [SerializeField] Clan clanFocus_ClanSpecialty;
    [SerializeField] int clanSpecialtyCard_Number;
    [SerializeField] int actionCard_Number;

    [Header("Color Manager")]
    [SerializeField] ColorManager colorManager;

    [Header("Battle Cards")]
    [SerializeField] BattleCardObject cardObject;

    public SO_NarutoCard battle_Akatsuki;
    public SO_NarutoCard battle_Hyuga;
    public SO_NarutoCard battle_Otsutsuki;
    public SO_NarutoCard battle_Senju;
    public SO_NarutoCard battle_Uchiha;
    public SO_NarutoCard battle_Uzumaki;
    public SO_NarutoCard battle_Ally_Rare;
    public SO_NarutoCard battle_Ally_Epic;
    public SO_NarutoCard battle_Ally_Legendary;

    [Header("Action Cards")]
    public SO_ActionCard actionCards;
    [SerializeField] ActionCardObject actionCardObject;

    [Header("Clan Specialty Cards")]
    [SerializeField] ClanSpecialtyCardObject clanSpecialtyCardObject;

    public SO_ClanSpecialtyCard clanSpecialty_Akatsuki;
    public SO_ClanSpecialtyCard clanSpecialty_Hyuga;
    public SO_ClanSpecialtyCard clanSpecialty_Otsutsuki;
    public SO_ClanSpecialtyCard clanSpecialty_Senju;
    public SO_ClanSpecialtyCard clanSpecialty_Uchiha;
    public SO_ClanSpecialtyCard clanSpecialty_Uzumaki;

    #region Sprites
    [Header("Tier Images")]
    public Sprite Tier_Common_Image;
    public Sprite Tier_Rare_Image;
    public Sprite Tier_Epic_Image;
    public Sprite Tier_Legendary_Image;

    [Header("States Images")]
    public Sprite State_Immediately_Image;
    public Sprite State_AfterWar_Image;
    public Sprite State_IfWin_Image;
    public Sprite State_IfLoose_Image;
    public Sprite State_IfBattleAdvantage_Image;
    public Sprite State_IfNotBattleAdvantage_Image;

    [Header("Effect Images")]
    public Sprite Skull;
    public Sprite Shield;

    [Header("Nation Symbols")]
    public Sprite NationSymbol_ANBU;
    public Sprite NationSymbol_Cliff;
    public Sprite NationSymbol_Cloud;
    public Sprite NationSymbol_Craftsmen;
    public Sprite NationSymbol_Curtain;
    public Sprite NationSymbol_Dawn;
    public Sprite NationSymbol_Eddy;
    public Sprite NationSymbol_Fields;
    public Sprite NationSymbol_Grass;
    public Sprite NationSymbol_Hawk;
    public Sprite NationSymbol_Haze;
    public Sprite NationSymbol_HotWater;
    public Sprite NationSymbol_Iron;
    public Sprite NationSymbol_JiroIsland;
    public Sprite NationSymbol_KikaIsland;
    public Sprite NationSymbol_LandOfAncestors;
    public Sprite NationSymbol_Leaf;
    public Sprite NationSymbol_Lock;
    public Sprite NationSymbol_Mines;
    public Sprite NationSymbol_Mist;
    public Sprite NationSymbol_Moon;
    public Sprite NationSymbol_MountMyoboku;
    public Sprite NationSymbol_Mountain;
    public Sprite NationSymbol_Noodles;
    public Sprite NationSymbol_Rain;
    public Sprite NationSymbol_Rice;
    public Sprite NationSymbol_River;
    public Sprite NationSymbol_Sand;
    public Sprite NationSymbol_Sea;
    public Sprite NationSymbol_Sky;
    public Sprite NationSymbol_Snow;
    public Sprite NationSymbol_Sound;
    public Sprite NationSymbol_Star;
    public Sprite NationSymbol_Stone;
    public Sprite NationSymbol_Tea;
    public Sprite NationSymbol_ThreeTunders;
    public Sprite NationSymbol_TurtleIsland;
    public Sprite NationSymbol_Vegetable;
    public Sprite NationSymbol_Waterfall;
    public Sprite NationSymbol_Wave;

    [Header("Resources")]
    public Sprite Resource_Boat;
    public Sprite Resource_Chuunin;
    public Sprite Resource_Jounin;
    public Sprite Resource_Kage;
    public Sprite Resource_ActionCard;
    public Sprite Resource_ClanCard_Akatsuki;
    public Sprite Resource_ClanCard_Hyuga;
    public Sprite Resource_ClanCard_Otsutsuki;
    public Sprite Resource_ClanCard_Senju;
    public Sprite Resource_ClanCard_Uchiha;
    public Sprite Resource_ClanCard_Uzumaki;
    public Sprite Resource_ClanCard_Ally;
    public Sprite Resource_Ally_Rare;
    public Sprite Resource_Ally_Epic;
    public Sprite Resource_Ally_Legendary;
    public Sprite Resource_Effect_Poison;
    public Sprite Resource_Effect_Paralyze;
    public Sprite Resource_Effect_Illusion;
    public Sprite Resource_Effect_Freeze;
    public Sprite Resource_Effect_Chain;
    public Sprite Resource_Effect_Coin;
    public Sprite Resource_Effect_TailedBeast;
    public Sprite Resource_Effect_Influence_UP;
    public Sprite Resource_Effect_Influence_DOWN;

    [Header("ActionCard Types")]
    public Sprite Swap;
    public Sprite ClanCard;
    public Sprite Ally_Rare;
    public Sprite Ally_Epic;
    public Sprite Ally_Legendary;
    public Sprite Upgrade;

    public Sprite Piece_Boat;
    public Sprite Piece_Chuunin;
    public Sprite Piece_Jounin;
    public Sprite Piece_Kage;

    public Sprite Travel;
    public Sprite War;
    public Sprite Defence;
    public Sprite Support;
    public Sprite HealingOintment;

    public Sprite Fire;
    public Sprite FireBlock;

    public Sprite Token_Genjutsu;
    public Sprite Token_Paralyze;
    public Sprite Token_Freeze;
    public Sprite Token_Poison;
    public Sprite Token_Chain;

    public Sprite DominanceTrack;
    public Sprite Reroll;
    public Sprite Trade;
    public Sprite Turns;

    public Sprite Specialty;

    [Header("ClanSpecialty Types")]
    public Sprite Icon_Akatsuki;
    public Sprite Icon_Hyuga;
    public Sprite Icon_Otsutsuki;
    public Sprite Icon_Senju;
    public Sprite Icon_Uchiha;
    public Sprite Icon_Uzumaki;
    #endregion

    #endregion


    //--------------------


    private void Start()
    {
        mainManager = FindObjectOfType<MainManager>();

        CardsDisplay();
    }
    private void Update()
    {
        if (!mainManager.isTakingScreenShots)
        {
            CardsDisplay();
        }
    }


    //--------------------


    void CardsDisplay()
    {
        //Battle Cards
        switch (clanFocus_BattleCard)
        {
            case Clan.None:
                break;

            case Clan.Akatsuki:
                if (battle_Akatsuki.cardList.Count <= 0) { }
                else if (battleCard_Number >= 0 && battleCard_Number < battle_Akatsuki.cardList.Count)
                    DisplayBattleCard(battle_Akatsuki.cardList[battleCard_Number]);
                else
                    DisplayBattleCard(battle_Akatsuki.cardList[battle_Akatsuki.cardList.Count - 1]);
                break;
            case Clan.Hyuga:
                if (battle_Hyuga.cardList.Count <= 0) { }
                else if (battleCard_Number >= 0 && battleCard_Number < battle_Hyuga.cardList.Count)
                    DisplayBattleCard(battle_Hyuga.cardList[battleCard_Number]);
                else
                    DisplayBattleCard(battle_Hyuga.cardList[battle_Hyuga.cardList.Count - 1]);
                break;
            case Clan.Otsutsuki:
                if (battle_Otsutsuki.cardList.Count <= 0) { }
                else if (battleCard_Number >= 0 && battleCard_Number < battle_Otsutsuki.cardList.Count)
                    DisplayBattleCard(battle_Otsutsuki.cardList[battleCard_Number]);
                else
                    DisplayBattleCard(battle_Otsutsuki.cardList[battle_Otsutsuki.cardList.Count - 1]);
                break;
            case Clan.Senju:
                if (battle_Senju.cardList.Count <= 0) { }
                else if (battleCard_Number >= 0 && battleCard_Number < battle_Senju.cardList.Count)
                    DisplayBattleCard(battle_Senju.cardList[battleCard_Number]);
                else
                    DisplayBattleCard(battle_Senju.cardList[battle_Senju.cardList.Count - 1]);
                break;
            case Clan.Uchiha:
                if (battle_Uchiha.cardList.Count <= 0) { }
                else if (battleCard_Number >= 0 && battleCard_Number < battle_Uchiha.cardList.Count)
                    DisplayBattleCard(battle_Uchiha.cardList[battleCard_Number]);
                else
                    DisplayBattleCard(battle_Uchiha.cardList[battle_Uchiha.cardList.Count - 1]);
                break;
            case Clan.Uzumaki:
                if (battle_Uzumaki.cardList.Count <= 0) { }
                else if (battleCard_Number >= 0 && battleCard_Number < battle_Uzumaki.cardList.Count)
                    DisplayBattleCard(battle_Uzumaki.cardList[battleCard_Number]);
                else
                    DisplayBattleCard(battle_Uzumaki.cardList[battle_Uzumaki.cardList.Count - 1]);
                break;
            case Clan.Ally_Rare:
                if (battle_Ally_Rare.cardList.Count <= 0) { }
                else if (battleCard_Number >= 0 && battleCard_Number < battle_Ally_Rare.cardList.Count)
                    DisplayBattleCard(battle_Ally_Rare.cardList[battleCard_Number]);
                else
                    DisplayBattleCard(battle_Ally_Rare.cardList[battle_Ally_Rare.cardList.Count - 1]);
                break;
            case Clan.Ally_Epic:
                if (battle_Ally_Epic.cardList.Count <= 0) { }
                else if (battleCard_Number >= 0 && battleCard_Number < battle_Ally_Epic.cardList.Count)
                    DisplayBattleCard(battle_Ally_Epic.cardList[battleCard_Number]);
                else
                    DisplayBattleCard(battle_Ally_Epic.cardList[battle_Ally_Epic.cardList.Count - 1]);
                break;
            case Clan.Ally_Legendary:
                if (battle_Ally_Legendary.cardList.Count <= 0) { }
                else if (battleCard_Number >= 0 && battleCard_Number < battle_Ally_Legendary.cardList.Count)
                    DisplayBattleCard(battle_Ally_Legendary.cardList[battleCard_Number]);
                else
                    DisplayBattleCard(battle_Ally_Legendary.cardList[battle_Ally_Legendary.cardList.Count - 1]);
                break;

            default:
                break;
        }

        //Action Cards
        if (actionCards.actionCardList.Count <= 0) { }
        else if (actionCard_Number >= 0 && actionCard_Number < actionCards.actionCardList.Count)
            DisplayActionCard(actionCards.actionCardList[actionCard_Number]);
        else
            DisplayActionCard(actionCards.actionCardList[actionCards.actionCardList.Count - 1]);

        //Clan Spacialty Cards
        switch (clanFocus_ClanSpecialty)
        {
            case Clan.None:
                break;

            case Clan.Akatsuki:
                if (clanSpecialty_Akatsuki.clanSpecialtyCardList.Count <= 0) { }
                else if (clanSpecialtyCard_Number >= 0 && clanSpecialtyCard_Number < clanSpecialty_Akatsuki.clanSpecialtyCardList.Count)
                    DisplayClanSpecialty(clanSpecialty_Akatsuki.clanSpecialtyCardList[clanSpecialtyCard_Number]);
                else
                    DisplayClanSpecialty(clanSpecialty_Akatsuki.clanSpecialtyCardList[clanSpecialty_Akatsuki.clanSpecialtyCardList.Count - 1]);
                break;
            case Clan.Hyuga:
                if (clanSpecialty_Hyuga.clanSpecialtyCardList.Count <= 0) { }
                else if (clanSpecialtyCard_Number >= 0 && clanSpecialtyCard_Number < clanSpecialty_Hyuga.clanSpecialtyCardList.Count)
                    DisplayClanSpecialty(clanSpecialty_Hyuga.clanSpecialtyCardList[clanSpecialtyCard_Number]);
                else
                    DisplayClanSpecialty(clanSpecialty_Hyuga.clanSpecialtyCardList[clanSpecialty_Hyuga.clanSpecialtyCardList.Count - 1]);
                break;
            case Clan.Otsutsuki:
                if (clanSpecialty_Otsutsuki.clanSpecialtyCardList.Count <= 0) { }
                else if (clanSpecialtyCard_Number >= 0 && clanSpecialtyCard_Number < clanSpecialty_Otsutsuki.clanSpecialtyCardList.Count)
                    DisplayClanSpecialty(clanSpecialty_Otsutsuki.clanSpecialtyCardList[clanSpecialtyCard_Number]);
                else
                    DisplayClanSpecialty(clanSpecialty_Otsutsuki.clanSpecialtyCardList[clanSpecialty_Otsutsuki.clanSpecialtyCardList.Count - 1]);
                break;
            case Clan.Senju:
                if (clanSpecialty_Senju.clanSpecialtyCardList.Count <= 0) { }
                else if (clanSpecialtyCard_Number >= 0 && clanSpecialtyCard_Number < clanSpecialty_Senju.clanSpecialtyCardList.Count)
                    DisplayClanSpecialty(clanSpecialty_Senju.clanSpecialtyCardList[clanSpecialtyCard_Number]);
                else
                    DisplayClanSpecialty(clanSpecialty_Senju.clanSpecialtyCardList[clanSpecialty_Senju.clanSpecialtyCardList.Count - 1]);
                break;
            case Clan.Uchiha:
                if (clanSpecialty_Uchiha.clanSpecialtyCardList.Count <= 0) { }
                else if (clanSpecialtyCard_Number >= 0 && clanSpecialtyCard_Number < clanSpecialty_Uchiha.clanSpecialtyCardList.Count)
                    DisplayClanSpecialty(clanSpecialty_Uchiha.clanSpecialtyCardList[clanSpecialtyCard_Number]);
                else
                    DisplayClanSpecialty(clanSpecialty_Uchiha.clanSpecialtyCardList[clanSpecialty_Uchiha.clanSpecialtyCardList.Count - 1]);
                break;
            case Clan.Uzumaki:
                if (clanSpecialty_Uzumaki.clanSpecialtyCardList.Count <= 0) { }
                else if (clanSpecialtyCard_Number >= 0 && clanSpecialtyCard_Number < clanSpecialty_Uzumaki.clanSpecialtyCardList.Count)
                    DisplayClanSpecialty(clanSpecialty_Uzumaki.clanSpecialtyCardList[clanSpecialtyCard_Number]);
                else
                    DisplayClanSpecialty(clanSpecialty_Uzumaki.clanSpecialtyCardList[clanSpecialty_Uzumaki.clanSpecialtyCardList.Count - 1]);
                break;

            default:
                break;
        }
    }


    //--------------------


    public void DisplayBattleCard(BattleCard battleCard)
    {
        //Colors depending on Card Type
        switch (battleCard.clan)
        {
            case Clan.None:
                break;

            case Clan.Akatsuki:
                for (int j = 0; j < cardObject.background_Image.Count; j++)
                {
                    cardObject.background_Image[j].color = colorManager.GetAkatsuki_BackgroundColor();
                }
                cardObject.Frame_Image.color = colorManager.GetAkatsuki_BorderColor();
                for (int j = 0; j < cardObject.landOrigins_Image.Count; j++)
                {
                    cardObject.landOrigins_Image[j].color = colorManager.GetAkatsuki_LandOriginColor();
                }

                cardObject.name_Text.color = colorManager.GetAkatsuki_TextColor();
                cardObject.loreInfo_Text.color = colorManager.GetAkatsuki_TextColor();
                
                cardObject.taijutsuValue_Text.color = colorManager.GetAkatsuki_TextColor();
                cardObject.ninjutsuValue_Text.color = colorManager.GetAkatsuki_TextColor();
                cardObject.genjutsuValue_Text.color = colorManager.GetAkatsuki_TextColor();

                cardObject.Taijutsu_Border_Image.color = colorManager.GetAkatsuki_BorderColor();
                cardObject.Ninjutsu_Border_Image.color = colorManager.GetAkatsuki_BorderColor();
                cardObject.Genjutsu_Border_Image.color = colorManager.GetAkatsuki_BorderColor();
                cardObject.Heal_Border_Image.color = colorManager.GetAkatsuki_BorderColor();
                cardObject.HealBlock_Border_Image.color = colorManager.GetAkatsuki_BorderColor();

                for (int j = 0; j < cardObject.states_Image.Count; j++)
                {
                    cardObject.states_Image[j].GetComponentInChildren<Image>().color = colorManager.GetAkatsuki_TextColor();
                }
                cardObject.effectText_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetAkatsuki_TextColor();
                cardObject.effectTextIcon_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetAkatsuki_TextColor();
                break;
            case Clan.Hyuga:
                for (int j = 0; j < cardObject.background_Image.Count; j++)
                {
                    cardObject.background_Image[j].color = colorManager.GetHyuga_BackgroundColor();
                }
                cardObject.Frame_Image.color = colorManager.GetHyuga_BorderColor();
                for (int j = 0; j < cardObject.landOrigins_Image.Count; j++)
                {
                    cardObject.landOrigins_Image[j].color = colorManager.GetHyuga_LandOriginColor();
                }

                cardObject.name_Text.color = colorManager.GetHyuga_TextColor();
                cardObject.loreInfo_Text.color = colorManager.GetHyuga_TextColor();
                
                cardObject.taijutsuValue_Text.color = colorManager.GetHyuga_TextColor();
                cardObject.ninjutsuValue_Text.color = colorManager.GetHyuga_TextColor();
                cardObject.genjutsuValue_Text.color = colorManager.GetHyuga_TextColor();

                cardObject.Taijutsu_Border_Image.color = colorManager.GetHyuga_BorderColor();
                cardObject.Ninjutsu_Border_Image.color = colorManager.GetHyuga_BorderColor();
                cardObject.Genjutsu_Border_Image.color = colorManager.GetHyuga_BorderColor();
                cardObject.Heal_Border_Image.color = colorManager.GetHyuga_BorderColor();
                cardObject.HealBlock_Border_Image.color = colorManager.GetHyuga_BorderColor();

                for (int j = 0; j < cardObject.states_Image.Count; j++)
                {
                    cardObject.states_Image[j].GetComponentInChildren<Image>().color = colorManager.GetHyuga_TextColor();
                }
                cardObject.effectText_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetHyuga_TextColor();
                cardObject.effectTextIcon_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetHyuga_TextColor();
                break;
            case Clan.Otsutsuki:
                for (int j = 0; j < cardObject.background_Image.Count; j++)
                {
                    cardObject.background_Image[j].color = colorManager.GetOtsutsuki_BackgroundColor();
                }
                cardObject.Frame_Image.color = colorManager.GetOtsutsuki_BorderColor();
                for (int j = 0; j < cardObject.landOrigins_Image.Count; j++)
                {
                    cardObject.landOrigins_Image[j].color = colorManager.GetOtsutsuki_LandOriginColor();
                }

                cardObject.name_Text.color = colorManager.GetOtsutsuki_TextColor();
                cardObject.loreInfo_Text.color = colorManager.GetOtsutsuki_TextColor();

                cardObject.taijutsuValue_Text.color = colorManager.GetOtsutsuki_TextColor();
                cardObject.ninjutsuValue_Text.color = colorManager.GetOtsutsuki_TextColor();
                cardObject.genjutsuValue_Text.color = colorManager.GetOtsutsuki_TextColor();

                cardObject.Taijutsu_Border_Image.color = colorManager.GetOtsutsuki_BorderColor();
                cardObject.Ninjutsu_Border_Image.color = colorManager.GetOtsutsuki_BorderColor();
                cardObject.Genjutsu_Border_Image.color = colorManager.GetOtsutsuki_BorderColor();
                cardObject.Heal_Border_Image.color = colorManager.GetOtsutsuki_BorderColor();
                cardObject.HealBlock_Border_Image.color = colorManager.GetOtsutsuki_BorderColor();

                for (int j = 0; j < cardObject.states_Image.Count; j++)
                {
                    cardObject.states_Image[j].GetComponentInChildren<Image>().color = colorManager.GetOtsutsuki_TextColor();
                }
                cardObject.effectText_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetOtsutsuki_TextColor();
                cardObject.effectTextIcon_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetOtsutsuki_TextColor();
                break;
            case Clan.Senju:
                for (int j = 0; j < cardObject.background_Image.Count; j++)
                {
                    cardObject.background_Image[j].color = colorManager.GetSenju_BackgroundColor();
                }
                cardObject.Frame_Image.color = colorManager.GetSenju_BorderColor();
                for (int j = 0; j < cardObject.landOrigins_Image.Count; j++)
                {
                    cardObject.landOrigins_Image[j].color = colorManager.GetSenju_LandOriginColor();
                }

                cardObject.name_Text.color = colorManager.GetSenju_TextColor();
                cardObject.loreInfo_Text.color = colorManager.GetSenju_TextColor();

                cardObject.taijutsuValue_Text.color = colorManager.GetSenju_TextColor();
                cardObject.ninjutsuValue_Text.color = colorManager.GetSenju_TextColor();
                cardObject.genjutsuValue_Text.color = colorManager.GetSenju_TextColor();

                cardObject.Taijutsu_Border_Image.color = colorManager.GetSenju_BorderColor();
                cardObject.Ninjutsu_Border_Image.color = colorManager.GetSenju_BorderColor();
                cardObject.Genjutsu_Border_Image.color = colorManager.GetSenju_BorderColor();
                cardObject.Heal_Border_Image.color = colorManager.GetSenju_BorderColor();
                cardObject.HealBlock_Border_Image.color = colorManager.GetSenju_BorderColor();

                for (int j = 0; j < cardObject.states_Image.Count; j++)
                {
                    cardObject.states_Image[j].GetComponentInChildren<Image>().color = colorManager.GetSenju_TextColor();
                }
                cardObject.effectText_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetSenju_TextColor();
                cardObject.effectTextIcon_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetSenju_TextColor();
                break;
            case Clan.Uchiha:
                for (int j = 0; j < cardObject.background_Image.Count; j++)
                {
                    cardObject.background_Image[j].color = colorManager.GetUchiha_BackgroundColor();
                }
                cardObject.Frame_Image.color = colorManager.GetUchiha_BorderColor();
                for (int j = 0; j < cardObject.landOrigins_Image.Count; j++)
                {
                    cardObject.landOrigins_Image[j].color = colorManager.GetUchiha_LandOriginColor();
                }

                cardObject.name_Text.color = colorManager.GetUchiha_TextColor();
                cardObject.loreInfo_Text.color = colorManager.GetUchiha_TextColor();

                cardObject.taijutsuValue_Text.color = colorManager.GetUchiha_TextColor();
                cardObject.ninjutsuValue_Text.color = colorManager.GetUchiha_TextColor();
                cardObject.genjutsuValue_Text.color = colorManager.GetUchiha_TextColor();

                cardObject.Taijutsu_Border_Image.color = colorManager.GetUchiha_BorderColor();
                cardObject.Ninjutsu_Border_Image.color = colorManager.GetUchiha_BorderColor();
                cardObject.Genjutsu_Border_Image.color = colorManager.GetUchiha_BorderColor();
                cardObject.Heal_Border_Image.color = colorManager.GetUchiha_BorderColor();
                cardObject.HealBlock_Border_Image.color = colorManager.GetUchiha_BorderColor();

                for (int j = 0; j < cardObject.states_Image.Count; j++)
                {
                    cardObject.states_Image[j].GetComponentInChildren<Image>().color = colorManager.GetUchiha_TextColor();
                }
                cardObject.effectText_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetUchiha_TextColor();
                cardObject.effectTextIcon_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetUchiha_TextColor();
                break;
            case Clan.Uzumaki:
                for (int j = 0; j < cardObject.background_Image.Count; j++)
                {
                    cardObject.background_Image[j].color = colorManager.GetUzumaki_BackgroundColor();
                }
                cardObject.Frame_Image.color = colorManager.GetUzumaki_BorderColor();
                for (int j = 0; j < cardObject.landOrigins_Image.Count; j++)
                {
                    cardObject.landOrigins_Image[j].color = colorManager.GetUzumaki_LandOriginColor();
                }

                cardObject.name_Text.color = colorManager.GetUzumaki_TextColor();
                cardObject.loreInfo_Text.color = colorManager.GetUzumaki_TextColor();

                cardObject.taijutsuValue_Text.color = colorManager.GetUzumaki_TextColor();
                cardObject.ninjutsuValue_Text.color = colorManager.GetUzumaki_TextColor();
                cardObject.genjutsuValue_Text.color = colorManager.GetUzumaki_TextColor();

                cardObject.Taijutsu_Border_Image.color = colorManager.GetUzumaki_BorderColor();
                cardObject.Ninjutsu_Border_Image.color = colorManager.GetUzumaki_BorderColor();
                cardObject.Genjutsu_Border_Image.color = colorManager.GetUzumaki_BorderColor();
                cardObject.Heal_Border_Image.color = colorManager.GetUzumaki_BorderColor();
                cardObject.HealBlock_Border_Image.color = colorManager.GetUzumaki_BorderColor();

                for (int j = 0; j < cardObject.states_Image.Count; j++)
                {
                    cardObject.states_Image[j].GetComponentInChildren<Image>().color = colorManager.GetUzumaki_TextColor();
                }
                cardObject.effectText_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetUzumaki_TextColor();
                cardObject.effectTextIcon_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetUzumaki_TextColor();
                break;
            case Clan.Ally:
                for (int j = 0; j < cardObject.background_Image.Count; j++)
                {
                    cardObject.background_Image[j].color = colorManager.GetAlly_BackgroundColor();
                }
                cardObject.Frame_Image.color = colorManager.GetAlly_BorderColor();
                for (int j = 0; j < cardObject.landOrigins_Image.Count; j++)
                {
                    cardObject.landOrigins_Image[j].color = colorManager.GetAlly_LandOriginColor();
                }

                cardObject.name_Text.color = colorManager.GetAlly_TextColor();
                cardObject.loreInfo_Text.color = colorManager.GetAlly_TextColor();

                cardObject.taijutsuValue_Text.color = colorManager.GetAlly_TextColor();
                cardObject.ninjutsuValue_Text.color = colorManager.GetAlly_TextColor();
                cardObject.genjutsuValue_Text.color = colorManager.GetAlly_TextColor();

                cardObject.Taijutsu_Border_Image.color = colorManager.GetAlly_BorderColor();
                cardObject.Ninjutsu_Border_Image.color = colorManager.GetAlly_BorderColor();
                cardObject.Genjutsu_Border_Image.color = colorManager.GetAlly_BorderColor();
                cardObject.Heal_Border_Image.color = colorManager.GetAlly_BorderColor();
                cardObject.HealBlock_Border_Image.color = colorManager.GetAlly_BorderColor();

                for (int j = 0; j < cardObject.states_Image.Count; j++)
                {
                    cardObject.states_Image[j].GetComponentInChildren<Image>().color = colorManager.GetAlly_TextColor();
                }
                cardObject.effectText_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetAlly_TextColor();
                cardObject.effectTextIcon_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetAlly_TextColor();
                break;

            default:
                break;
        }

        //Name Box
        cardObject.name_Text.text = battleCard.name;
        cardObject.loreInfo_Text.text = battleCard.loreInfo;
        for (int j = 0; j < cardObject.landOrigins_Image.Count; j++)
        {
            switch (battleCard.landOrigins)
            {
                case landOrigins.None:
                    cardObject.landOrigins_Image[j].sprite = null;
                    break;
                case landOrigins.ANBU:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_ANBU;
                    break;
                case landOrigins.Cliff:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Cliff;
                    break;
                case landOrigins.Cloud:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Cloud;
                    break;
                case landOrigins.Craftsmen:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Craftsmen;
                    break;
                case landOrigins.Curtain:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Curtain;
                    break;
                case landOrigins.Dawn:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Dawn;
                    break;
                case landOrigins.Eddy:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Eddy;
                    break;
                case landOrigins.Fields:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Fields;
                    break;
                case landOrigins.Grass:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Grass;
                    break;
                case landOrigins.Hawk:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Hawk;
                    break;
                case landOrigins.Haze:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Haze;
                    break;
                case landOrigins.HotWater:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_HotWater;
                    break;
                case landOrigins.Iron:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Iron;
                    break;
                case landOrigins.JiroIsland:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_JiroIsland;
                    break;
                case landOrigins.KikaIsland:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_KikaIsland;
                    break;
                case landOrigins.LandOfAncestors:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_LandOfAncestors;
                    break;
                case landOrigins.Leaf:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Leaf;
                    break;
                case landOrigins.Lock:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Lock;
                    break;
                case landOrigins.Mines:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Mines;
                    break;
                case landOrigins.Mist:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Mist;
                    break;
                case landOrigins.Moon:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Moon;
                    break;
                case landOrigins.MountMyoboku:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_MountMyoboku;
                    break;
                case landOrigins.Mountain:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Mountain;
                    break;
                case landOrigins.Noodles:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Noodles;
                    break;
                case landOrigins.Rain:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Rain;
                    break;
                case landOrigins.Rice:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Rice;
                    break;
                case landOrigins.River:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_River;
                    break;
                case landOrigins.Sand:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Sand;
                    break;
                case landOrigins.Sea:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Sea;
                    break;
                case landOrigins.Sky:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Sky;
                    break;
                case landOrigins.Snow:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Snow;
                    break;
                case landOrigins.Sound:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Sound;
                    break;
                case landOrigins.Star:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Star;
                    break;
                case landOrigins.Stone:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Stone;
                    break;
                case landOrigins.Tea:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Tea;
                    break;
                case landOrigins.ThreeTunders:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_ThreeTunders;
                    break;
                case landOrigins.TurtleIsland:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_TurtleIsland;
                    break;
                case landOrigins.Vegetable:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Vegetable;
                    break;
                case landOrigins.Waterfall:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Waterfall;
                    break;
                case landOrigins.Wave:
                    cardObject.landOrigins_Image[j].sprite = NationSymbol_Wave;
                    break;

                default:
                    cardObject.landOrigins_Image[j].sprite = null;
                    break;
            }
        }

        //Character Image
        cardObject.characterImage.sprite = battleCard.characterSprite;

        //Values
        cardObject.taijutsuValue_Text.text = battleCard.TaijutsuValue.ToString();
        cardObject.ninjutsuValue_Text.text = battleCard.NinjutsuValue.ToString();
        cardObject.genjutsuValue_Text.text = battleCard.GenjutsuValue.ToString();

        //Heal
        switch (battleCard.heal)
        {
            case Heal.None:
                cardObject.healParent.SetActive(false);
                cardObject.healBlockParent.SetActive(false);
                break;
            case Heal.Heal:
                cardObject.healParent.SetActive(true);
                cardObject.healBlockParent.SetActive(false);
                break;
            case Heal.HealBlock:
                cardObject.healParent.SetActive(false);
                cardObject.healBlockParent.SetActive(true);
                break;

            default:
                break;
        }

        //Tailed Beast Heads
        switch (battleCard.headAmount)
        {
            case 0:
                cardObject.headParent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 60);
                cardObject.heads_Image[0].SetActive(false);
                cardObject.heads_Image[1].SetActive(false);
                cardObject.heads_Image[2].SetActive(false);
                cardObject.heads_Image[3].SetActive(false);
                cardObject.heads_Image[4].SetActive(false);
                break;
            case 1:
                cardObject.headParent.GetComponent<RectTransform>().sizeDelta = new Vector2(60, 60);
                cardObject.heads_Image[0].SetActive(true);
                cardObject.heads_Image[1].SetActive(false);
                cardObject.heads_Image[2].SetActive(false);
                cardObject.heads_Image[3].SetActive(false);
                cardObject.heads_Image[4].SetActive(false);
                break;
            case 2:
                cardObject.headParent.GetComponent<RectTransform>().sizeDelta = new Vector2(140, 60);
                cardObject.heads_Image[0].SetActive(true);
                cardObject.heads_Image[1].SetActive(true);
                cardObject.heads_Image[2].SetActive(false);
                cardObject.heads_Image[3].SetActive(false);
                cardObject.heads_Image[4].SetActive(false);
                break;
            case 3:
                cardObject.headParent.GetComponent<RectTransform>().sizeDelta = new Vector2(220, 60);
                cardObject.heads_Image[0].SetActive(true);
                cardObject.heads_Image[1].SetActive(true);
                cardObject.heads_Image[2].SetActive(true);
                cardObject.heads_Image[3].SetActive(false);
                cardObject.heads_Image[4].SetActive(false);
                break;
            case 4:
                cardObject.headParent.GetComponent<RectTransform>().sizeDelta = new Vector2(300, 60);
                cardObject.heads_Image[0].SetActive(true);
                cardObject.heads_Image[1].SetActive(true);
                cardObject.heads_Image[2].SetActive(true);
                cardObject.heads_Image[3].SetActive(true);
                cardObject.heads_Image[4].SetActive(false);
                break;
            case 5:
                cardObject.headParent.GetComponent<RectTransform>().sizeDelta = new Vector2(380, 60);
                cardObject.heads_Image[0].SetActive(true);
                cardObject.heads_Image[1].SetActive(true);
                cardObject.heads_Image[2].SetActive(true);
                cardObject.heads_Image[3].SetActive(true);
                cardObject.heads_Image[4].SetActive(true);
                break;

            default:
                break;
        }

        //Effect
        //  - States - Change the size of box based on the amount of States
        for (int j = 0; j < cardObject.states_Image.Count; j++)
            cardObject.states_Image[j].SetActive(true);
        switch (battleCard.effectState.Count)
        {
            case 0:
                cardObject.states_Parent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);
                for (int j = 0; j < cardObject.states_Image.Count; j++)
                    cardObject.states_Image[j].SetActive(false);
                break;
            case 1:
                cardObject.states_Parent.GetComponent<RectTransform>().sizeDelta = new Vector2(120, 120);
                for (int j = 1; j < cardObject.states_Image.Count; j++)
                    cardObject.states_Image[j].SetActive(false);
                break;
            case 2:
                cardObject.states_Parent.GetComponent<RectTransform>().sizeDelta = new Vector2(280, 120);
                for (int j = 2; j < cardObject.states_Image.Count; j++)
                    cardObject.states_Image[j].SetActive(false);
                break;
            case 3:
                cardObject.states_Parent.GetComponent<RectTransform>().sizeDelta = new Vector2(440, 120);
                for (int j = 3; j < cardObject.states_Image.Count; j++)
                    cardObject.states_Image[j].SetActive(false);
                break;
            case 4:
                cardObject.states_Parent.GetComponent<RectTransform>().sizeDelta = new Vector2(600, 120);
                for (int j = 4; j < cardObject.states_Image.Count; j++)
                    cardObject.states_Image[j].SetActive(false);
                break;
            case 5:
                cardObject.states_Parent.GetComponent<RectTransform>().sizeDelta = new Vector2(760, 120);
                for (int j = 5; j < cardObject.states_Image.Count; j++)
                    cardObject.states_Image[j].SetActive(false);
                break;
            case 6:
                cardObject.states_Parent.GetComponent<RectTransform>().sizeDelta = new Vector2(920, 120);
                for (int j = 6; j < cardObject.states_Image.Count; j++)
                    cardObject.states_Image[j].SetActive(false);
                break;

            default:
                break;
        }
        for (int j = 0; j < battleCard.effectState.Count; j++)
        {
            switch (battleCard.effectState[j])
            {
                case State.None:
                    cardObject.states_Image[j].GetComponent<Image>().sprite = null;
                    break;
                case State.Immediately:
                    cardObject.states_Image[j].GetComponent<Image>().sprite = State_Immediately_Image;
                    break;
                case State.AfterTheWar:
                    cardObject.states_Image[j].GetComponent<Image>().sprite = State_AfterWar_Image;
                    break;
                case State.ifWin:
                    cardObject.states_Image[j].GetComponent<Image>().sprite = State_IfWin_Image;
                    break;
                case State.ifLose:
                    cardObject.states_Image[j].GetComponent<Image>().sprite = State_IfLoose_Image;
                    break;
                case State.ifBattleAdvantage:
                    cardObject.states_Image[j].GetComponent<Image>().sprite = State_IfBattleAdvantage_Image;
                    break;
                case State.ifNotBattleAdvantage:
                    cardObject.states_Image[j].GetComponent<Image>().sprite = State_IfNotBattleAdvantage_Image;
                    break;

                default:
                    break;
            }
        }

        //  - Effect Text
        #region
        //If == null
        if (battleCard.effectIcon.Count <= 0)
        {
            DisplayTextOnly(battleCard);
        }

        else if (battleCard.effectIcon.Count == 1)
        {
            //If == 0 + text
            if (battleCard.effectIcon[0] == EffectIcon.None)
            {
                DisplayTextOnly(battleCard);
            }

            //If != 1 + text
            else if (battleCard.effectIcon[0] != EffectIcon.None)
            {
                if (battleCard.effectText == "")
                {
                    Display1Icon(battleCard);
                }
                else
                {
                    DisplayTextAndIcon(battleCard, 0);
                }
            }
        }
        else if (battleCard.effectIcon.Count == 2)
        {
            //If 0, 0
            if (battleCard.effectIcon[0] == EffectIcon.None && battleCard.effectIcon[1] == EffectIcon.None)
            {
                DisplayTextOnly(battleCard);
            }
            //If 1, 0
            else if (battleCard.effectIcon[0] != EffectIcon.None && battleCard.effectIcon[1] == EffectIcon.None)
            {
                if (battleCard.effectText == "")
                {
                    Display1Icon(battleCard);
                }
                else
                {
                    DisplayTextAndIcon(battleCard, 0);
                }
            }
            //If 0, 1
            if (battleCard.effectIcon[0] == EffectIcon.None && battleCard.effectIcon[1] != EffectIcon.None)
            {
                if (battleCard.effectText == "")
                {
                    Display1Icon(battleCard);
                }
                else
                {
                    DisplayTextAndIcon(battleCard, 1);
                }
            }
            //If 1, 1
            if (battleCard.effectIcon[0] != EffectIcon.None && battleCard.effectIcon[1] != EffectIcon.None)
            {
                Display2Icons(battleCard, 0, 1);
            }
        }
        else if (battleCard.effectIcon.Count == 3)
        {
            //If 0, 0, 0
            if (battleCard.effectIcon[0] == EffectIcon.None && battleCard.effectIcon[1] == EffectIcon.None & battleCard.effectIcon[2] == EffectIcon.None)
            {
                DisplayTextOnly(battleCard);
            }
            //If 1, 0, 0
            else if (battleCard.effectIcon[0] != EffectIcon.None && battleCard.effectIcon[1] == EffectIcon.None & battleCard.effectIcon[2] == EffectIcon.None)
            {
                if (battleCard.effectText == "")
                {
                    Display1Icon(battleCard);
                }
                else
                {
                    DisplayTextAndIcon(battleCard, 0);
                }
            }
            //If 0, 1, 0
            else if (battleCard.effectIcon[0] == EffectIcon.None && battleCard.effectIcon[1] != EffectIcon.None & battleCard.effectIcon[2] == EffectIcon.None)
            {
                if (battleCard.effectText == "")
                {
                    Display1Icon(battleCard);
                }
                else
                {
                    DisplayTextAndIcon(battleCard, 1);
                }
            }
            //If 0, 0, 1
            else if (battleCard.effectIcon[0] == EffectIcon.None && battleCard.effectIcon[1] == EffectIcon.None & battleCard.effectIcon[2] != EffectIcon.None)
            {
                if (battleCard.effectText == "")
                {
                    Display1Icon(battleCard);
                }
                else
                {
                    DisplayTextAndIcon(battleCard, 2);
                }
            }
            //If 1, 1, 0
            else if (battleCard.effectIcon[0] != EffectIcon.None && battleCard.effectIcon[1] != EffectIcon.None & battleCard.effectIcon[2] == EffectIcon.None)
            {
                Display2Icons(battleCard, 0, 1);
            }
            //If 1, 0, 1
            else if (battleCard.effectIcon[0] != EffectIcon.None && battleCard.effectIcon[1] == EffectIcon.None & battleCard.effectIcon[2] != EffectIcon.None)
            {
                Display2Icons(battleCard, 0 , 2);
            }
            //If 0, 1, 1
            else if (battleCard.effectIcon[0] == EffectIcon.None && battleCard.effectIcon[1] != EffectIcon.None & battleCard.effectIcon[2] != EffectIcon.None)
            {
                Display2Icons(battleCard, 1, 2);
            }
            //If 1, 1, 1
            else if (battleCard.effectIcon[0] != EffectIcon.None && battleCard.effectIcon[1] != EffectIcon.None & battleCard.effectIcon[2] != EffectIcon.None)
            {
                Display3Icons(battleCard);
            }
        }
        else if (battleCard.effectIcon.Count >= 4)
        {
            DisplayTextOnly(battleCard);
        }
        #endregion

        //  - Tier
        switch (battleCard.tier)
        {
            case Tier.None:
                cardObject.tier_Image.sprite = null;
                break;

            case Tier.Common:
                cardObject.tier_Image.sprite = Tier_Common_Image;
                break;
            case Tier.Rare:
                cardObject.tier_Image.sprite = Tier_Rare_Image;
                break;
            case Tier.Epic:
                cardObject.tier_Image.sprite = Tier_Epic_Image;
                break;
            case Tier.Legendary:
                cardObject.tier_Image.sprite = Tier_Legendary_Image;
                break;

            default:
                break;
        }

        //Resources
        #region
        //Set all ResourceImages false
        for (int j = 0; j < cardObject.resources_Image.Count; j++)
        {
            cardObject.resources_Image[j].GetComponent<Image>().color = new Color(1, 1, 1, 1);
            cardObject.resources_Image[j].SetActive(false);
        }

        //Set relevant ResourceImages true
        #region
        if (battleCard.resources[0].amount >= 1 && battleCard.resources[0].resources != Resources.None)
            cardObject.resources_Image[0].SetActive(true);
        if (battleCard.resources[0].amount >= 2 && battleCard.resources[0].resources != Resources.None)
            cardObject.resources_Image[1].SetActive(true);
        if (battleCard.resources[0].amount >= 3 && battleCard.resources[0].resources != Resources.None)
            cardObject.resources_Image[2].SetActive(true);
        if (battleCard.resources[0].amount >= 4 && battleCard.resources[0].resources != Resources.None)
            cardObject.resources_Image[3].SetActive(true);

        if (battleCard.resources[1].amount >= 1 && battleCard.resources[1].resources != Resources.None)
            cardObject.resources_Image[4].SetActive(true);
        if (battleCard.resources[1].amount >= 2 && battleCard.resources[1].resources != Resources.None)
            cardObject.resources_Image[5].SetActive(true);
        if (battleCard.resources[1].amount >= 3 && battleCard.resources[1].resources != Resources.None)
            cardObject.resources_Image[6].SetActive(true);
        if (battleCard.resources[1].amount >= 4 && battleCard.resources[1].resources != Resources.None)
            cardObject.resources_Image[7].SetActive(true);

        if (battleCard.resources[2].amount >= 1 && battleCard.resources[2].resources != Resources.None)
            cardObject.resources_Image[8].SetActive(true);
        if (battleCard.resources[2].amount >= 2 && battleCard.resources[2].resources != Resources.None)
            cardObject.resources_Image[9].SetActive(true);
        if (battleCard.resources[2].amount >= 3 && battleCard.resources[2].resources != Resources.None)
            cardObject.resources_Image[10].SetActive(true);
        if (battleCard.resources[2].amount >= 4 && battleCard.resources[2].resources != Resources.None)
            cardObject.resources_Image[11].SetActive(true);

        if (battleCard.resources[3].amount >= 1 && battleCard.resources[3].resources != Resources.None)
            cardObject.resources_Image[12].SetActive(true);
        if (battleCard.resources[3].amount >= 2 && battleCard.resources[3].resources != Resources.None)
            cardObject.resources_Image[13].SetActive(true);
        if (battleCard.resources[3].amount >= 3 && battleCard.resources[3].resources != Resources.None)
            cardObject.resources_Image[14].SetActive(true);
        if (battleCard.resources[3].amount >= 4 && battleCard.resources[3].resources != Resources.None)
            cardObject.resources_Image[15].SetActive(true);
        #endregion

        //Change all ResourceImages to the correct Resource
        for (int j = 0; j < 4; j++)
        {
            switch (battleCard.resources[j].resources)
            {
                case Resources.None:
                    break;
                case Resources.Boat:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                    {
                        cardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Boat;

                        switch (battleCard.clan)
                        {
                            case Clan.None:
                                cardObject.resources_Image[k].GetComponent<Image>().sprite = null;
                                break;
                            case Clan.Akatsuki:
                                cardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetAkatsuki_BorderColor();
                                break;
                            case Clan.Hyuga:
                                cardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetHyuga_BorderColor();
                                break;
                            case Clan.Otsutsuki:
                                cardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetOtsutsuki_BorderColor();
                                break;
                            case Clan.Senju:
                                cardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetSenju_BorderColor();
                                break;
                            case Clan.Uchiha:
                                cardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetUchiha_BorderColor();
                                break;
                            case Clan.Uzumaki:
                                cardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetUzumaki_BorderColor();
                                break;
                            case Clan.Ally:
                                cardObject.resources_Image[k].GetComponent<Image>().color = new Color(0, 0, 0, 1);
                                break;

                            default:
                                break;
                        }
                    }
                    break;
                case Resources.Chuunin:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                    {
                        switch (battleCard.clan)
                        {
                            case Clan.None:
                                cardObject.resources_Image[k].GetComponent<Image>().sprite = null;
                                break;
                            case Clan.Akatsuki:
                                cardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetAkatsuki_BorderColor();
                                break;
                            case Clan.Hyuga:
                                cardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetHyuga_BorderColor();
                                break;
                            case Clan.Otsutsuki:
                                cardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetOtsutsuki_BorderColor();
                                break;
                            case Clan.Senju:
                                cardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetSenju_BorderColor();
                                break;
                            case Clan.Uchiha:
                                cardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetUchiha_BorderColor();
                                break;
                            case Clan.Uzumaki:
                                cardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetUzumaki_BorderColor();
                                break;
                            case Clan.Ally:
                                cardObject.resources_Image[k].GetComponent<Image>().color = new Color(0, 0, 0, 1);
                                break;

                            default:
                                break;
                        }

                        cardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Chuunin;
                    }
                    break;
                case Resources.Jounin:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                    {
                        switch (battleCard.clan)
                        {
                            case Clan.None:
                                cardObject.resources_Image[k].GetComponent<Image>().sprite = null;
                                break;
                            case Clan.Akatsuki:
                                cardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetAkatsuki_BorderColor();
                                break;
                            case Clan.Hyuga:
                                cardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetHyuga_BorderColor();
                                break;
                            case Clan.Otsutsuki:
                                cardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetOtsutsuki_BorderColor();
                                break;
                            case Clan.Senju:
                                cardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetSenju_BorderColor();
                                break;
                            case Clan.Uchiha:
                                cardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetUchiha_BorderColor();
                                break;
                            case Clan.Uzumaki:
                                cardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetUzumaki_BorderColor();
                                break;
                            case Clan.Ally:
                                cardObject.resources_Image[k].GetComponent<Image>().color = new Color(0, 0, 0, 1);
                                break;

                            default:
                                break;
                        }

                        cardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Jounin;
                    }
                    break;
                case Resources.Kage:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                    {
                        switch (battleCard.clan)
                        {
                            case Clan.None:
                                cardObject.resources_Image[k].GetComponent<Image>().sprite = null;
                                break;
                            case Clan.Akatsuki:
                                cardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetAkatsuki_BorderColor();
                                break;
                            case Clan.Hyuga:
                                cardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetHyuga_BorderColor();
                                break;
                            case Clan.Otsutsuki:
                                cardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetOtsutsuki_BorderColor();
                                break;
                            case Clan.Senju:
                                cardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetSenju_BorderColor();
                                break;
                            case Clan.Uchiha:
                                cardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetUchiha_BorderColor();
                                break;
                            case Clan.Uzumaki:
                                cardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetUzumaki_BorderColor();
                                break;
                            case Clan.Ally:
                                cardObject.resources_Image[k].GetComponent<Image>().color = new Color(0, 0, 0, 1);
                                break;

                            default:
                                break;
                        }

                        cardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Kage;
                    }
                    break;
                case Resources.ActionCard:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                        cardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_ActionCard;
                    break;
                case Resources.ClanCard:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                    {
                        switch (battleCard.clan)
                        {
                            case Clan.None:
                                cardObject.resources_Image[k].GetComponent<Image>().sprite = null;
                                break;
                            case Clan.Akatsuki:
                                cardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_ClanCard_Akatsuki;
                                break;
                            case Clan.Hyuga:
                                cardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_ClanCard_Hyuga;
                                break;
                            case Clan.Otsutsuki:
                                cardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_ClanCard_Otsutsuki;
                                break;
                            case Clan.Senju:
                                cardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_ClanCard_Senju;
                                break;
                            case Clan.Uchiha:
                                cardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_ClanCard_Uchiha;
                                break;
                            case Clan.Uzumaki:
                                cardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_ClanCard_Uzumaki;
                                break;
                            case Clan.Ally:
                                cardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_ClanCard_Ally;
                                break;

                            default:
                                break;
                        }
                    }
                    break;
                case Resources.Ally_Rare:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                        cardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Ally_Rare;
                    break;
                case Resources.Ally_Epic:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                        cardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Ally_Epic;
                    break;
                case Resources.Ally_Legendary:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                        cardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Ally_Legendary;
                    break;
                case Resources.Effect_Poison:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                        cardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Effect_Poison;
                    break;
                case Resources.Effect_Paralyze:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                        cardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Effect_Paralyze;
                    break;
                case Resources.Effect_Illusion:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                        cardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Effect_Illusion;
                    break;
                case Resources.Effect_Freeze:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                        cardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Effect_Freeze;
                    break;
                case Resources.Effect_Chain:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                        cardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Effect_Chain;
                    break;
                case Resources.Influence_UP:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                        cardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Effect_Influence_UP;
                    break;
                case Resources.Influence_DOWN:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                        cardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Effect_Influence_DOWN;
                    break;
                case Resources.Coin:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                        cardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Effect_Coin;
                    break;
                case Resources.TailedBeast:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                        cardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Effect_TailedBeast;
                    break;

                default:
                    break;
            }
        }


        #endregion
    }

    void DisplayTextOnly(BattleCard battleCard)
    {
        cardObject.effectText_Parent.SetActive(true);
        cardObject.effectTextIcon_Parent.SetActive(false);
        cardObject.effectIcon_Parent.SetActive(false);

        cardObject.effectText_Parent.GetComponentInChildren<TextMeshProUGUI>().text = battleCard.effectText;
    }
    void Display3Icons(BattleCard battleCard)
    {
        cardObject.effectText_Parent.SetActive(false);
        cardObject.effectTextIcon_Parent.SetActive(false);
        cardObject.effectIcon_Parent.SetActive(true);

        cardObject.effectIcons[0].SetActive(false);
        cardObject.effectIcons[1].SetActive(false);
        cardObject.effectIcons[2].SetActive(false);

        //Make correct size
        cardObject.effectIcon_Parent.GetComponent<RectTransform>().sizeDelta = new Vector2(1400, 453.3f);

        //Show correct image
        for (int j = 0; j < 3; j++)
        {
            if (battleCard.effectIcon[j] == EffectIcon.Skull)
            {
                cardObject.effectIcons[j].SetActive(true);
                cardObject.effectIcons[j].GetComponentInChildren<Image>().sprite = Skull;
            }
            else if (battleCard.effectIcon[j] == EffectIcon.Shield)
            {
                cardObject.effectIcons[j].SetActive(true);
                cardObject.effectIcons[j].GetComponentInChildren<Image>().sprite = Shield;
            }
        }
    }
    void Display2Icons(BattleCard battleCard, int k, int l)
    {
        cardObject.effectText_Parent.SetActive(false);
        cardObject.effectTextIcon_Parent.SetActive(false);
        cardObject.effectIcon_Parent.SetActive(true);

        cardObject.effectIcons[0].SetActive(false);
        cardObject.effectIcons[1].SetActive(false);
        cardObject.effectIcons[2].SetActive(false);

        //Make correct size
        cardObject.effectIcon_Parent.GetComponent<RectTransform>().sizeDelta = new Vector2(926.6f, 453.3f);

        //Show correct image
        //k
        if (battleCard.effectIcon[k] == EffectIcon.Skull)
        {
            cardObject.effectIcons[k].SetActive(true);
            cardObject.effectIcons[k].GetComponentInChildren<Image>().sprite = Skull;
        }
        else if (battleCard.effectIcon[k] == EffectIcon.Shield)
        {
            cardObject.effectIcons[k].SetActive(true);
            cardObject.effectIcons[k].GetComponentInChildren<Image>().sprite = Shield;
        }

        //l
        if (battleCard.effectIcon[l] == EffectIcon.Skull)
        {
            cardObject.effectIcons[l].SetActive(true);
            cardObject.effectIcons[l].GetComponentInChildren<Image>().sprite = Skull;
        }
        else if (battleCard.effectIcon[l] == EffectIcon.Shield)
        {
            cardObject.effectIcons[l].SetActive(true);
            cardObject.effectIcons[l].GetComponentInChildren<Image>().sprite = Shield;
        }
    }
    void Display1Icon(BattleCard battleCard)
    {
        cardObject.effectIcons[0].SetActive(true);
        cardObject.effectIcons[1].SetActive(false);
        cardObject.effectIcons[2].SetActive(false);

        cardObject.effectText_Parent.SetActive(false);
        cardObject.effectTextIcon_Parent.SetActive(false);
        cardObject.effectIcon_Parent.SetActive(true);

        cardObject.effectIcon_Parent.GetComponent<RectTransform>().sizeDelta = new Vector2(453.3f, 453.3f);

        if (battleCard.effectIcon[0] == EffectIcon.Skull)
        {
            cardObject.effectIcons[0].GetComponentInChildren<Image>().sprite = Skull;
        }
        else if (battleCard.effectIcon[0] == EffectIcon.Shield)
        {
            cardObject.effectIcons[0].GetComponentInChildren<Image>().sprite = Shield;
        }
    }
    void DisplayTextAndIcon(BattleCard battleCard, int k)
    {
        cardObject.effectText_Parent.SetActive(false);
        cardObject.effectTextIcon_Parent.SetActive(true);
        cardObject.effectIcon_Parent.SetActive(false);

        cardObject.effectTextIcon_Parent.GetComponentInChildren<TextMeshProUGUI>().text = battleCard.effectText;

        if (battleCard.effectIcon[k] == EffectIcon.Skull)
        {
            cardObject.effectTextIcon_Parent.GetComponentInChildren<Image>().sprite = Skull;
        }
        else if (battleCard.effectIcon[k] == EffectIcon.Shield)
        {
            cardObject.effectTextIcon_Parent.GetComponentInChildren<Image>().sprite = Shield;
        }
    }


    //--------------------


    public void DisplayActionCard(ActionCard actioncard)
    {
        actionCardObject.name.text = actioncard.name;
        actionCardObject.description.text = actioncard.description;

        //Icon
        switch (actioncard.category)
        {
            case ActionCards.None:
                actionCardObject.icon.sprite = null;
                break;
            case ActionCards.Swap:
                actionCardObject.icon.sprite = Swap;
                break;
            case ActionCards.ClanCard:
                actionCardObject.icon.sprite = ClanCard;
                break;
            case ActionCards.Ally_Rare:
                actionCardObject.icon.sprite = Ally_Rare;
                break;
            case ActionCards.Ally_Epic:
                actionCardObject.icon.sprite = Ally_Epic;
                break;
            case ActionCards.Ally_Legendary:
                actionCardObject.icon.sprite = Ally_Legendary;
                break;
            case ActionCards.Upgrade:
                actionCardObject.icon.sprite = Upgrade;
                break;

            case ActionCards.Piece_Boat:
                actionCardObject.icon.sprite = Piece_Boat;
                break;
            case ActionCards.Piece_Chuunin:
                actionCardObject.icon.sprite = Piece_Chuunin;
                break;
            case ActionCards.Piece_Jounin:
                actionCardObject.icon.sprite = Piece_Jounin;
                break;
            case ActionCards.Piece_Kage:
                actionCardObject.icon.sprite = Piece_Kage;
                break;

            case ActionCards.Travel:
                actionCardObject.icon.sprite = Travel;
                break;
            case ActionCards.War:
                actionCardObject.icon.sprite = War;
                break;
            case ActionCards.Defence:
                actionCardObject.icon.sprite = Defence;
                break;
            case ActionCards.Support:
                actionCardObject.icon.sprite = Support;
                break;
            case ActionCards.HealingOintment:
                actionCardObject.icon.sprite = HealingOintment;
                break;

            case ActionCards.Fire:
                actionCardObject.icon.sprite = Fire;
                break;
            case ActionCards.FireBlock:
                actionCardObject.icon.sprite = FireBlock;
                break;

            case ActionCards.Token_Genjutsu:
                actionCardObject.icon.sprite = Token_Genjutsu;
                break;
            case ActionCards.Token_Paralyze:
                actionCardObject.icon.sprite = Token_Paralyze;
                break;
            case ActionCards.Token_Freeze:
                actionCardObject.icon.sprite = Token_Freeze;
                break;
            case ActionCards.Token_Poison:
                actionCardObject.icon.sprite = Token_Poison;
                break;
            case ActionCards.Token_Chain:
                actionCardObject.icon.sprite = Token_Chain;
                break;

            case ActionCards.DominanceTrack:
                actionCardObject.icon.sprite = DominanceTrack;
                break;
            case ActionCards.Reroll:
                actionCardObject.icon.sprite = Reroll;
                break;
            case ActionCards.Trade:
                actionCardObject.icon.sprite = Trade;
                break;
            case ActionCards.Turns:
                actionCardObject.icon.sprite = Turns;
                break;
            case ActionCards.Specialty:
                actionCardObject.icon.sprite = Specialty;
                break;

            default:
                break;
        }

        //Type
        switch (actioncard.type)
        {
            case ActionCardTypes.None:
                actionCardObject.type.text = null;
                break;
            case ActionCardTypes.Action:
                actionCardObject.type.text = "Action";
                break;
            case ActionCardTypes.Reaction:
                actionCardObject.type.text = "Reaction";
                break;
            case ActionCardTypes.ActionReaction:
                actionCardObject.type.text = "Action / Reaction";
                break;
            case ActionCardTypes.SpecialAction:
                actionCardObject.type.text = "Special Action";
                break;

            default:
                break;
        }

        //Coin
        #region
        //Set al Coin Images = false
        for (int j = 0; j < actionCardObject.coin.Count; j++)
        {
            actionCardObject.coin[j].SetActive(false);
        }

        //Make relevant coin Images visible
        switch (actioncard.cost)
        {
            case 1:
                actionCardObject.coin[0].SetActive(true);
                break;
            case 2:
                actionCardObject.coin[0].SetActive(true);
                actionCardObject.coin[1].SetActive(true);
                break;
            case 3:
                actionCardObject.coin[0].SetActive(true);
                actionCardObject.coin[1].SetActive(true);
                actionCardObject.coin[2].SetActive(true);
                break;
            case 4:
                actionCardObject.coin[0].SetActive(true);
                actionCardObject.coin[1].SetActive(true);
                actionCardObject.coin[2].SetActive(true);
                actionCardObject.coin[3].SetActive(true);
                break;
            case 5:
                actionCardObject.coin[0].SetActive(true);
                actionCardObject.coin[1].SetActive(true);
                actionCardObject.coin[2].SetActive(true);
                actionCardObject.coin[3].SetActive(true);
                actionCardObject.coin[4].SetActive(true);
                break;
            case 6:
                actionCardObject.coin[0].SetActive(true);
                actionCardObject.coin[1].SetActive(true);
                actionCardObject.coin[2].SetActive(true);
                actionCardObject.coin[3].SetActive(true);
                actionCardObject.coin[4].SetActive(true);
                actionCardObject.coin[5].SetActive(true);
                break;
            default:
                break;
        }
        #endregion

        //FireBlock
        if (actioncard.fireBlock)
            actionCardObject.fireBlock.SetActive(true);
        else
            actionCardObject.fireBlock.SetActive(false);

        //Strength
        if (actioncard.strength == "0" || actioncard.strength == "")
        {
            actionCardObject.strength.SetActive(false);
        }
        else
        {
            actionCardObject.strength.SetActive(true);
            actionCardObject.strength.GetComponentInChildren<TextMeshProUGUI>().text = actioncard.strength;
        }
    }


    //--------------------


    public void DisplayClanSpecialty(ClanSpecialtyCard clanSpecialtyCard)
    {
        //Clan Type changes
        switch (clanSpecialtyCard.clan)
        {
            case Clan.None:
                break;

            case Clan.Akatsuki:
                clanSpecialtyCardObject.backgorund.color = colorManager.GetAkatsuki_BackgroundColor();
                clanSpecialtyCardObject.backgorund_over.color = colorManager.GetAkatsuki_BackgroundColor();
                clanSpecialtyCardObject.frame.color = colorManager.GetAkatsuki_BorderColor();
                clanSpecialtyCardObject.header.color = colorManager.GetAkatsuki_TextColor();
                clanSpecialtyCardObject.description.color = colorManager.GetAkatsuki_TextColor();
                clanSpecialtyCardObject.clanSymbol.sprite = Icon_Akatsuki;
                break;
            case Clan.Hyuga:
                clanSpecialtyCardObject.backgorund.color = colorManager.GetHyuga_BackgroundColor();
                clanSpecialtyCardObject.backgorund_over.color = colorManager.GetHyuga_BackgroundColor();
                clanSpecialtyCardObject.frame.color = colorManager.GetHyuga_BorderColor();
                clanSpecialtyCardObject.header.color = colorManager.GetHyuga_TextColor();
                clanSpecialtyCardObject.description.color = colorManager.GetHyuga_TextColor();
                clanSpecialtyCardObject.clanSymbol.sprite = Icon_Hyuga;
                break;
            case Clan.Otsutsuki:
                clanSpecialtyCardObject.backgorund.color = colorManager.GetOtsutsuki_BackgroundColor();
                clanSpecialtyCardObject.backgorund_over.color = colorManager.GetOtsutsuki_BackgroundColor();
                clanSpecialtyCardObject.frame.color = colorManager.GetOtsutsuki_BorderColor();
                clanSpecialtyCardObject.header.color = colorManager.GetOtsutsuki_TextColor();
                clanSpecialtyCardObject.description.color = colorManager.GetOtsutsuki_TextColor();
                clanSpecialtyCardObject.clanSymbol.sprite = Icon_Otsutsuki;
                break;
            case Clan.Senju:
                clanSpecialtyCardObject.backgorund.color = colorManager.GetSenju_BackgroundColor();
                clanSpecialtyCardObject.backgorund_over.color = colorManager.GetSenju_BackgroundColor();
                clanSpecialtyCardObject.frame.color = colorManager.GetSenju_BorderColor();
                clanSpecialtyCardObject.header.color = colorManager.GetSenju_TextColor();
                clanSpecialtyCardObject.description.color = colorManager.GetSenju_TextColor();
                clanSpecialtyCardObject.clanSymbol.sprite = Icon_Senju;
                break;
            case Clan.Uchiha:
                clanSpecialtyCardObject.backgorund.color = colorManager.GetUchiha_BackgroundColor();
                clanSpecialtyCardObject.backgorund_over.color = colorManager.GetUchiha_BackgroundColor();
                clanSpecialtyCardObject.frame.color = colorManager.GetUchiha_BorderColor();
                clanSpecialtyCardObject.header.color = colorManager.GetUchiha_TextColor();
                clanSpecialtyCardObject.description.color = colorManager.GetUchiha_TextColor();
                clanSpecialtyCardObject.clanSymbol.sprite = Icon_Uchiha;
                break;
            case Clan.Uzumaki:
                clanSpecialtyCardObject.backgorund.color = colorManager.GetUzumaki_BackgroundColor();
                clanSpecialtyCardObject.backgorund_over.color = colorManager.GetUzumaki_BackgroundColor();
                clanSpecialtyCardObject.frame.color = colorManager.GetUzumaki_BorderColor();
                clanSpecialtyCardObject.header.color = colorManager.GetUzumaki_TextColor();
                clanSpecialtyCardObject.description.color = colorManager.GetUzumaki_TextColor();
                clanSpecialtyCardObject.clanSymbol.sprite = Icon_Uzumaki;
                break;

            default:
                break;
        }

        //Text
        clanSpecialtyCardObject.header.text = clanSpecialtyCard.name;
        clanSpecialtyCardObject.description.text = clanSpecialtyCard.description;

        //Image
        clanSpecialtyCardObject.cardImage.sprite = clanSpecialtyCard.image;

        //Cost
        for (int j = 0; j < clanSpecialtyCardObject.coinImage.Count; j++)
        {
            clanSpecialtyCardObject.coinImage[j].SetActive(false);
        }
        switch (clanSpecialtyCard.cost)
        {
            case 1:
                clanSpecialtyCardObject.coinImage[0].SetActive(true);
                break;
            case 2:
                clanSpecialtyCardObject.coinImage[0].SetActive(true);
                clanSpecialtyCardObject.coinImage[1].SetActive(true);
                break;
            case 3:
                clanSpecialtyCardObject.coinImage[0].SetActive(true);
                clanSpecialtyCardObject.coinImage[1].SetActive(true);
                clanSpecialtyCardObject.coinImage[2].SetActive(true);
                break;
            case 4:
                clanSpecialtyCardObject.coinImage[0].SetActive(true);
                clanSpecialtyCardObject.coinImage[1].SetActive(true);
                clanSpecialtyCardObject.coinImage[2].SetActive(true);
                clanSpecialtyCardObject.coinImage[3].SetActive(true);
                break;
            case 5:
                clanSpecialtyCardObject.coinImage[0].SetActive(true);
                clanSpecialtyCardObject.coinImage[1].SetActive(true);
                clanSpecialtyCardObject.coinImage[2].SetActive(true);
                clanSpecialtyCardObject.coinImage[3].SetActive(true);
                clanSpecialtyCardObject.coinImage[4].SetActive(true);
                break;

            default:
                break;
        }
    }
}

