using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class CardManager : MonoBehaviour
{
    #region Variables
    MainManager mainManager;
    
    [Header("Color Manager")]
    [SerializeField] ColorManager colorManager;

    [Header("Battle Cards")]
    [SerializeField] BattleCardObject battleCardObject;
    [SerializeField] TextMeshProUGUI battleCardDescriptionText;
    [SerializeField] TextMeshProUGUI battleCardIconTextDescriptionText;

    public SO_NarutoCard battle_Akatsuki_Awakening;
    public SO_NarutoCard battle_Akatsuki;
    public SO_NarutoCard battle_Hyuga;
    public SO_NarutoCard battle_Otsutsuki;
    public SO_NarutoCard battle_Senju;
    public SO_NarutoCard battle_Uchiha;
    public SO_NarutoCard battle_Uzumaki;
    public SO_NarutoCard battle_Kara;
    public SO_NarutoCard battle_Ally_Rare;
    public SO_NarutoCard battle_Ally_Epic;
    public SO_NarutoCard battle_Ally_Legendary;

    public Sprite box_Frame_Sprite;
    public Sprite boxHead_Frame_Sprite;
    public Sprite box_Background_Sprite;
    public Sprite boxHead_Background_Sprite;

    public Sprite circle_Empty;
    public Sprite circle_Heal;
    public Sprite circle_HealBlock;

    [Header("Action Cards")]
    public SO_ActionCard actionCards;
    [SerializeField] ActionCardObject actionCardObject;
    [SerializeField] TextMeshProUGUI actionCardDescriptionText;

    [Header("Clan Specialty Cards")]
    [SerializeField] ClanSpecialtyCardObject clanSpecialtyCardObject;
    [SerializeField] TextMeshProUGUI clanSpecialtyDescriptionText;

    public SO_ClanSpecialtyCard clanSpecialty_Akatsuki;
    public SO_ClanSpecialtyCard clanSpecialty_Hyuga;
    public SO_ClanSpecialtyCard clanSpecialty_Otsutsuki;
    public SO_ClanSpecialtyCard clanSpecialty_Senju;
    public SO_ClanSpecialtyCard clanSpecialty_Uchiha;
    public SO_ClanSpecialtyCard clanSpecialty_Uzumaki;
    public SO_ClanSpecialtyCard clanSpecialty_Kara;

    [Header("Event Cards")]
    public SO_Event eventCards;
    [SerializeField] EventCardObject eventCardObject;
    [SerializeField] TextMeshProUGUI eventCardHeader;
    [SerializeField] TextMeshProUGUI eventCardText;
    public Image eventImage;

    #region Sprites
    [Header("Tier Images")]
    public Sprite Tier_Trash_Image;
    public Sprite Tier_Common_Image;
    public Sprite Tier_Rare_Image;
    public Sprite Tier_Epic_Image;
    public Sprite Tier_Legendary_Image;

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
    public Sprite Resource_ClanCard_Kara;
    public Sprite Resource_ClanCard_Ally;
    public Sprite Resource_Ally_Rare;
    public Sprite Resource_Ally_Epic;
    public Sprite Resource_Ally_Legendary;
    public Sprite Resource_Effect_Poison;
    public Sprite Resource_Effect_Paralyze;
    public Sprite Resource_Effect_Illusion;
    public Sprite Resource_Effect_Freeze;
    public Sprite Resource_Effect_Chain;
    public Sprite Resource_Effect_Substitution;
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
    public Sprite LostPathLife;

    public Sprite Specialty;

    [Header("ClanSpecialty Types")]
    public Sprite Icon_Akatsuki;
    public Sprite Icon_Hyuga;
    public Sprite Icon_Otsutsuki;
    public Sprite Icon_Senju;
    public Sprite Icon_Uchiha;
    public Sprite Icon_Uzumaki;
    public Sprite Icon_Kara;
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
        switch (CardDisplayManager.Instance.clanFocus_BattleCard)
        {
            case Clan.None:
                break;

            case Clan.Akatsuki_Awakening:
                if (battle_Akatsuki_Awakening.cardList.Count <= 0) { }
                else if (CardDisplayManager.Instance.battleCard_Number >= 0 && CardDisplayManager.Instance.battleCard_Number < battle_Akatsuki_Awakening.cardList.Count)
                    DisplayBattleCard(battle_Akatsuki_Awakening.cardList[CardDisplayManager.Instance.battleCard_Number]);
                else
                    DisplayBattleCard(battle_Akatsuki_Awakening.cardList[battle_Akatsuki_Awakening.cardList.Count - 1]);
                break;
            case Clan.Akatsuki:
                if (battle_Akatsuki.cardList.Count <= 0) { }
                else if (CardDisplayManager.Instance.battleCard_Number >= 0 && CardDisplayManager.Instance.battleCard_Number < battle_Akatsuki.cardList.Count)
                    DisplayBattleCard(battle_Akatsuki.cardList[CardDisplayManager.Instance.battleCard_Number]);
                else
                    DisplayBattleCard(battle_Akatsuki.cardList[battle_Akatsuki.cardList.Count - 1]);
                break;
            case Clan.Hyuga:
                if (battle_Hyuga.cardList.Count <= 0) { }
                else if (CardDisplayManager.Instance.battleCard_Number >= 0 && CardDisplayManager.Instance.battleCard_Number < battle_Hyuga.cardList.Count)
                    DisplayBattleCard(battle_Hyuga.cardList[CardDisplayManager.Instance.battleCard_Number]);
                else
                    DisplayBattleCard(battle_Hyuga.cardList[battle_Hyuga.cardList.Count - 1]);
                break;
            case Clan.Otsutsuki:
                if (battle_Otsutsuki.cardList.Count <= 0) { }
                else if (CardDisplayManager.Instance.battleCard_Number >= 0 && CardDisplayManager.Instance.battleCard_Number < battle_Otsutsuki.cardList.Count)
                    DisplayBattleCard(battle_Otsutsuki.cardList[CardDisplayManager.Instance.battleCard_Number]);
                else
                    DisplayBattleCard(battle_Otsutsuki.cardList[battle_Otsutsuki.cardList.Count - 1]);
                break;
            case Clan.Senju:
                if (battle_Senju.cardList.Count <= 0) { }
                else if (CardDisplayManager.Instance.battleCard_Number >= 0 && CardDisplayManager.Instance.battleCard_Number < battle_Senju.cardList.Count)
                    DisplayBattleCard(battle_Senju.cardList[CardDisplayManager.Instance.battleCard_Number]);
                else
                    DisplayBattleCard(battle_Senju.cardList[battle_Senju.cardList.Count - 1]);
                break;
            case Clan.Uchiha:
                if (battle_Uchiha.cardList.Count <= 0) { }
                else if (CardDisplayManager.Instance.battleCard_Number >= 0 && CardDisplayManager.Instance.battleCard_Number < battle_Uchiha.cardList.Count)
                    DisplayBattleCard(battle_Uchiha.cardList[CardDisplayManager.Instance.battleCard_Number]);
                else
                    DisplayBattleCard(battle_Uchiha.cardList[battle_Uchiha.cardList.Count - 1]);
                break;
            case Clan.Uzumaki:
                if (battle_Uzumaki.cardList.Count <= 0) { }
                else if (CardDisplayManager.Instance.battleCard_Number >= 0 && CardDisplayManager.Instance.battleCard_Number < battle_Uzumaki.cardList.Count)
                    DisplayBattleCard(battle_Uzumaki.cardList[CardDisplayManager.Instance.battleCard_Number]);
                else
                    DisplayBattleCard(battle_Uzumaki.cardList[battle_Uzumaki.cardList.Count - 1]);
                break;
            case Clan.Kara:
                if (battle_Kara.cardList.Count <= 0) { }
                else if (CardDisplayManager.Instance.battleCard_Number >= 0 && CardDisplayManager.Instance.battleCard_Number < battle_Kara.cardList.Count)
                    DisplayBattleCard(battle_Kara.cardList[CardDisplayManager.Instance.battleCard_Number]);
                else
                    DisplayBattleCard(battle_Kara.cardList[battle_Kara.cardList.Count - 1]);
                break;
            case Clan.Ally_Rare:
                if (battle_Ally_Rare.cardList.Count <= 0) { }
                else if (CardDisplayManager.Instance.battleCard_Number >= 0 && CardDisplayManager.Instance.battleCard_Number < battle_Ally_Rare.cardList.Count)
                    DisplayBattleCard(battle_Ally_Rare.cardList[CardDisplayManager.Instance.battleCard_Number]);
                else
                    DisplayBattleCard(battle_Ally_Rare.cardList[battle_Ally_Rare.cardList.Count - 1]);
                break;
            case Clan.Ally_Epic:
                if (battle_Ally_Epic.cardList.Count <= 0) { }
                else if (CardDisplayManager.Instance.battleCard_Number >= 0 && CardDisplayManager.Instance.battleCard_Number < battle_Ally_Epic.cardList.Count)
                    DisplayBattleCard(battle_Ally_Epic.cardList[CardDisplayManager.Instance.battleCard_Number]);
                else
                    DisplayBattleCard(battle_Ally_Epic.cardList[battle_Ally_Epic.cardList.Count - 1]);
                break;
            case Clan.Ally_Legendary:
                if (battle_Ally_Legendary.cardList.Count <= 0) { }
                else if (CardDisplayManager.Instance.battleCard_Number >= 0 && CardDisplayManager.Instance.battleCard_Number < battle_Ally_Legendary.cardList.Count)
                    DisplayBattleCard(battle_Ally_Legendary.cardList[CardDisplayManager.Instance.battleCard_Number]);
                else
                    DisplayBattleCard(battle_Ally_Legendary.cardList[battle_Ally_Legendary.cardList.Count - 1]);
                break;

            default:
                break;
        }

        //Action Cards
        if (actionCards.actionCardList.Count <= 0) { }
        else if (CardDisplayManager.Instance.actionCard_Number >= 0 && CardDisplayManager.Instance.actionCard_Number < actionCards.actionCardList.Count)
            DisplayActionCard(actionCards.actionCardList[CardDisplayManager.Instance.actionCard_Number]);
        else
            DisplayActionCard(actionCards.actionCardList[actionCards.actionCardList.Count - 1]);

        //Clan Specialty Cards
        switch (CardDisplayManager.Instance.clanFocus_ClanSpecialty)
        {
            case Clan.None:
                break;

            case Clan.Akatsuki:
                if (clanSpecialty_Akatsuki.clanSpecialtyCardList.Count <= 0) { }
                else if (CardDisplayManager.Instance.clanSpecialtyCard_Number >= 0 && CardDisplayManager.Instance.clanSpecialtyCard_Number < clanSpecialty_Akatsuki.clanSpecialtyCardList.Count)
                    DisplayClanSpecialty(clanSpecialty_Akatsuki.clanSpecialtyCardList[CardDisplayManager.Instance.clanSpecialtyCard_Number]);
                else
                    DisplayClanSpecialty(clanSpecialty_Akatsuki.clanSpecialtyCardList[clanSpecialty_Akatsuki.clanSpecialtyCardList.Count - 1]);
                break;
            case Clan.Hyuga:
                if (clanSpecialty_Hyuga.clanSpecialtyCardList.Count <= 0) { }
                else if (CardDisplayManager.Instance.clanSpecialtyCard_Number >= 0 && CardDisplayManager.Instance.clanSpecialtyCard_Number < clanSpecialty_Hyuga.clanSpecialtyCardList.Count)
                    DisplayClanSpecialty(clanSpecialty_Hyuga.clanSpecialtyCardList[CardDisplayManager.Instance.clanSpecialtyCard_Number]);
                else
                    DisplayClanSpecialty(clanSpecialty_Hyuga.clanSpecialtyCardList[clanSpecialty_Hyuga.clanSpecialtyCardList.Count - 1]);
                break;
            case Clan.Otsutsuki:
                if (clanSpecialty_Otsutsuki.clanSpecialtyCardList.Count <= 0) { }
                else if (CardDisplayManager.Instance.clanSpecialtyCard_Number >= 0 && CardDisplayManager.Instance.clanSpecialtyCard_Number < clanSpecialty_Otsutsuki.clanSpecialtyCardList.Count)
                    DisplayClanSpecialty(clanSpecialty_Otsutsuki.clanSpecialtyCardList[CardDisplayManager.Instance.clanSpecialtyCard_Number]);
                else
                    DisplayClanSpecialty(clanSpecialty_Otsutsuki.clanSpecialtyCardList[clanSpecialty_Otsutsuki.clanSpecialtyCardList.Count - 1]);
                break;
            case Clan.Senju:
                if (clanSpecialty_Senju.clanSpecialtyCardList.Count <= 0) { }
                else if (CardDisplayManager.Instance.clanSpecialtyCard_Number >= 0 && CardDisplayManager.Instance.clanSpecialtyCard_Number < clanSpecialty_Senju.clanSpecialtyCardList.Count)
                    DisplayClanSpecialty(clanSpecialty_Senju.clanSpecialtyCardList[CardDisplayManager.Instance.clanSpecialtyCard_Number]);
                else
                    DisplayClanSpecialty(clanSpecialty_Senju.clanSpecialtyCardList[clanSpecialty_Senju.clanSpecialtyCardList.Count - 1]);
                break;
            case Clan.Uchiha:
                if (clanSpecialty_Uchiha.clanSpecialtyCardList.Count <= 0) { }
                else if (CardDisplayManager.Instance.clanSpecialtyCard_Number >= 0 && CardDisplayManager.Instance.clanSpecialtyCard_Number < clanSpecialty_Uchiha.clanSpecialtyCardList.Count)
                    DisplayClanSpecialty(clanSpecialty_Uchiha.clanSpecialtyCardList[CardDisplayManager.Instance.clanSpecialtyCard_Number]);
                else
                    DisplayClanSpecialty(clanSpecialty_Uchiha.clanSpecialtyCardList[clanSpecialty_Uchiha.clanSpecialtyCardList.Count - 1]);
                break;
            case Clan.Uzumaki:
                if (clanSpecialty_Uzumaki.clanSpecialtyCardList.Count <= 0) { }
                else if (CardDisplayManager.Instance.clanSpecialtyCard_Number >= 0 && CardDisplayManager.Instance.clanSpecialtyCard_Number < clanSpecialty_Uzumaki.clanSpecialtyCardList.Count)
                    DisplayClanSpecialty(clanSpecialty_Uzumaki.clanSpecialtyCardList[CardDisplayManager.Instance.clanSpecialtyCard_Number]);
                else
                    DisplayClanSpecialty(clanSpecialty_Uzumaki.clanSpecialtyCardList[clanSpecialty_Uzumaki.clanSpecialtyCardList.Count - 1]);
                break;
            case Clan.Kara:
                if (clanSpecialty_Kara.clanSpecialtyCardList.Count <= 0) { }
                else if (CardDisplayManager.Instance.clanSpecialtyCard_Number >= 0 && CardDisplayManager.Instance.clanSpecialtyCard_Number < clanSpecialty_Kara.clanSpecialtyCardList.Count)
                    DisplayClanSpecialty(clanSpecialty_Kara.clanSpecialtyCardList[CardDisplayManager.Instance.clanSpecialtyCard_Number]);
                else
                    DisplayClanSpecialty(clanSpecialty_Kara.clanSpecialtyCardList[clanSpecialty_Kara.clanSpecialtyCardList.Count - 1]);
                break;

            default:
                break;
        }

        //Events
        if (eventCards.eventCardList.Count <= 0) { }
        else if (CardDisplayManager.Instance.eventCard_Number >= 0 && CardDisplayManager.Instance.eventCard_Number < eventCards.eventCardList.Count)
            DisplayEventCard(eventCards.eventCardList[CardDisplayManager.Instance.eventCard_Number]);
        else
            DisplayEventCard(eventCards.eventCardList[eventCards.eventCardList.Count - 1]);
    }

    void ChangeDisplay_Buttons()
    {
        Event e = Event.current;

        if (e != null && e.isKey)
        {
            if (e.type == EventType.KeyDown)
            {
                // Check for specific key press
                if (e.keyCode == KeyCode.X)
                {
                    print("RightArrow isPressed");

                    if (MainManager.Instance.actionUI_Parent.activeInHierarchy)
                    {
                        CardDisplayManager.Instance.actionCard_Number++;
                    }
                    else if (MainManager.Instance.battleUI_Parent.activeInHierarchy)
                    {
                        CardDisplayManager.Instance.battleCard_Number++;
                    }
                    else if (MainManager.Instance.clanSpecialtyUI_Parent.activeInHierarchy)
                    {
                        CardDisplayManager.Instance.clanSpecialtyCard_Number++;
                    }
                    else if (MainManager.Instance.eventUI_Parent.activeInHierarchy)
                    {
                        CardDisplayManager.Instance.eventCard_Number++;
                    }
                }
                else if (e.keyCode == KeyCode.Z)
                {
                    print("LeftArrow isPressed");

                    if (MainManager.Instance.actionUI_Parent.activeInHierarchy)
                    {
                        CardDisplayManager.Instance.actionCard_Number--;
                    }
                    else if (MainManager.Instance.battleUI_Parent.activeInHierarchy)
                    {
                        CardDisplayManager.Instance.battleCard_Number--;
                    }
                    else if (MainManager.Instance.clanSpecialtyUI_Parent.activeInHierarchy)
                    {
                        CardDisplayManager.Instance.clanSpecialtyCard_Number--;
                    }
                    else if (MainManager.Instance.eventUI_Parent.activeInHierarchy)
                    {
                        CardDisplayManager.Instance.eventCard_Number--;
                    }
                }

                if (CardDisplayManager.Instance.actionCard_Number <= 0)
                {
                    CardDisplayManager.Instance.actionCard_Number = 0;
                }
                if (CardDisplayManager.Instance.battleCard_Number <= 0)
                {
                    CardDisplayManager.Instance.battleCard_Number = 0;
                }
                if (CardDisplayManager.Instance.clanSpecialtyCard_Number <= 0)
                {
                    CardDisplayManager.Instance.clanSpecialtyCard_Number = 0;
                }
                if (CardDisplayManager.Instance.eventCard_Number <= 0)
                {
                    CardDisplayManager.Instance.eventCard_Number = 0;
                }

                print("End");
            }
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

            case Clan.Akatsuki_Awakening:
                battleCardObject.outerFrame.color = colorManager.GetAkatsuki_Awakening_BorderColor();
                battleCardObject.background_Image.color = colorManager.GetAkatsuki_Awakening_BackgroundColor();

                battleCardObject.over_Circle.color = colorManager.GetAkatsuki_Awakening_CircleColor();
                battleCardObject.over_Field.color = colorManager.GetAkatsuki_Awakening_BackgroundColor();
                battleCardObject.over_Frame.color = colorManager.GetAkatsuki_Awakening_BorderColor();
                battleCardObject.under_Circle.color = colorManager.GetAkatsuki_Awakening_CircleColor();
                battleCardObject.under_Field.color = colorManager.GetAkatsuki_Awakening_BackgroundColor();
                battleCardObject.under_Frame.color = colorManager.GetAkatsuki_Awakening_BorderColor();

                battleCardObject.landOrigins_Image.color = colorManager.GetAkatsuki_Awakening_LandOriginColor();

                battleCardObject.name_Text.color = colorManager.GetAkatsuki_Awakening_TextColor();
                battleCardObject.loreInfo_Text.color = colorManager.GetAkatsuki_Awakening_TextColor();

                battleCardObject.taijutsuValue_Text.color = colorManager.GetAkatsuki_Awakening_TextColor();
                battleCardObject.ninjutsuValue_Text.color = colorManager.GetAkatsuki_Awakening_TextColor();
                battleCardObject.genjutsuValue_Text.color = colorManager.GetAkatsuki_Awakening_TextColor();

                battleCardObject.Taijutsu_Border_Image.color = colorManager.GetAkatsuki_Awakening_BorderColor();
                battleCardObject.Ninjutsu_Border_Image.color = colorManager.GetAkatsuki_Awakening_BorderColor();
                battleCardObject.Genjutsu_Border_Image.color = colorManager.GetAkatsuki_Awakening_BorderColor();

                battleCardObject.focusArea_Frame.color = colorManager.GetAkatsuki_BoxFrameColor();
                battleCardObject.box_Frame.color = colorManager.GetAkatsuki_BoxFrameColor();
                battleCardObject.effectText_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetAkatsuki_Awakening_TextColor();
                battleCardObject.effectTextIcon_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetAkatsuki_Awakening_TextColor();

                battleCardObject.head_Frame.color = colorManager.GetAkatsuki_Awakening_BoxFrameColor();
                battleCardObject.head_Amount.color = colorManager.GetAkatsuki_Awakening_TextColor();

                break;
            case Clan.Akatsuki:
                battleCardObject.outerFrame.color = colorManager.GetAkatsuki_BorderColor();
                battleCardObject.background_Image.color = colorManager.GetAkatsuki_BackgroundColor();

                battleCardObject.over_Circle.color = colorManager.GetAkatsuki_CircleColor();
                battleCardObject.over_Field.color = colorManager.GetAkatsuki_BackgroundColor();
                battleCardObject.over_Frame.color = colorManager.GetAkatsuki_BorderColor();
                battleCardObject.under_Circle.color = colorManager.GetAkatsuki_CircleColor();
                battleCardObject.under_Field.color = colorManager.GetAkatsuki_BackgroundColor();
                battleCardObject.under_Frame.color = colorManager.GetAkatsuki_BorderColor();

                battleCardObject.landOrigins_Image.color = colorManager.GetAkatsuki_LandOriginColor();

                battleCardObject.name_Text.color = colorManager.GetAkatsuki_TextColor();
                battleCardObject.loreInfo_Text.color = colorManager.GetAkatsuki_TextColor();
                
                battleCardObject.taijutsuValue_Text.color = colorManager.GetAkatsuki_TextColor();
                battleCardObject.ninjutsuValue_Text.color = colorManager.GetAkatsuki_TextColor();
                battleCardObject.genjutsuValue_Text.color = colorManager.GetAkatsuki_TextColor();

                battleCardObject.Taijutsu_Border_Image.color = colorManager.GetAkatsuki_BorderColor();
                battleCardObject.Ninjutsu_Border_Image.color = colorManager.GetAkatsuki_BorderColor();
                battleCardObject.Genjutsu_Border_Image.color = colorManager.GetAkatsuki_BorderColor();

                battleCardObject.focusArea_Frame.color = colorManager.GetAkatsuki_BoxFrameColor();
                battleCardObject.box_Frame.color = colorManager.GetAkatsuki_BoxFrameColor();
                battleCardObject.effectText_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetAkatsuki_TextColor();
                battleCardObject.effectTextIcon_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetAkatsuki_TextColor();

                battleCardObject.head_Frame.color = colorManager.GetAkatsuki_BoxFrameColor();
                battleCardObject.head_Amount.color = colorManager.GetAkatsuki_TextColor();

                break;
            case Clan.Hyuga:
                battleCardObject.outerFrame.color = colorManager.GetHyuga_BorderColor();
                battleCardObject.background_Image.color = colorManager.GetHyuga_BackgroundColor();

                battleCardObject.over_Circle.color = colorManager.GetHyuga_CircleColor();
                battleCardObject.over_Field.color = colorManager.GetHyuga_BackgroundColor();
                battleCardObject.over_Frame.color = colorManager.GetHyuga_BorderColor();
                battleCardObject.under_Circle.color = colorManager.GetHyuga_CircleColor();
                battleCardObject.under_Field.color = colorManager.GetHyuga_BackgroundColor();
                battleCardObject.under_Frame.color = colorManager.GetHyuga_BorderColor();

                battleCardObject.landOrigins_Image.color = colorManager.GetHyuga_LandOriginColor();

                battleCardObject.name_Text.color = colorManager.GetHyuga_TextColor();
                battleCardObject.loreInfo_Text.color = colorManager.GetHyuga_TextColor();

                battleCardObject.taijutsuValue_Text.color = colorManager.GetHyuga_TextColor();
                battleCardObject.ninjutsuValue_Text.color = colorManager.GetHyuga_TextColor();
                battleCardObject.genjutsuValue_Text.color = colorManager.GetHyuga_TextColor();

                battleCardObject.Taijutsu_Border_Image.color = colorManager.GetHyuga_BorderColor();
                battleCardObject.Ninjutsu_Border_Image.color = colorManager.GetHyuga_BorderColor();
                battleCardObject.Genjutsu_Border_Image.color = colorManager.GetHyuga_BorderColor();

                battleCardObject.focusArea_Frame.color = colorManager.GetHyuga_BoxFrameColor();
                battleCardObject.box_Frame.color = colorManager.GetHyuga_BoxFrameColor();
                battleCardObject.effectText_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetHyuga_TextColor();
                battleCardObject.effectTextIcon_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetHyuga_TextColor();

                battleCardObject.head_Frame.color = colorManager.GetHyuga_BoxFrameColor();
                battleCardObject.head_Amount.color = colorManager.GetHyuga_TextColor();

                break;
            case Clan.Otsutsuki:
                battleCardObject.outerFrame.color = colorManager.GetOtsutsuki_BorderColor();
                battleCardObject.background_Image.color = colorManager.GetOtsutsuki_BackgroundColor();

                battleCardObject.over_Circle.color = colorManager.GetOtsutsuki_CircleColor();
                battleCardObject.over_Field.color = colorManager.GetOtsutsuki_BackgroundColor();
                battleCardObject.over_Frame.color = colorManager.GetOtsutsuki_BorderColor();
                battleCardObject.under_Circle.color = colorManager.GetOtsutsuki_CircleColor();
                battleCardObject.under_Field.color = colorManager.GetOtsutsuki_BackgroundColor();
                battleCardObject.under_Frame.color = colorManager.GetOtsutsuki_BorderColor();

                battleCardObject.landOrigins_Image.color = colorManager.GetOtsutsuki_LandOriginColor();

                battleCardObject.name_Text.color = colorManager.GetOtsutsuki_TextColor();
                battleCardObject.loreInfo_Text.color = colorManager.GetOtsutsuki_TextColor();

                battleCardObject.taijutsuValue_Text.color = colorManager.GetOtsutsuki_TextColor();
                battleCardObject.ninjutsuValue_Text.color = colorManager.GetOtsutsuki_TextColor();
                battleCardObject.genjutsuValue_Text.color = colorManager.GetOtsutsuki_TextColor();

                battleCardObject.Taijutsu_Border_Image.color = colorManager.GetOtsutsuki_BorderColor();
                battleCardObject.Ninjutsu_Border_Image.color = colorManager.GetOtsutsuki_BorderColor();
                battleCardObject.Genjutsu_Border_Image.color = colorManager.GetOtsutsuki_BorderColor();

                battleCardObject.focusArea_Frame.color = colorManager.GetOtsutsuki_BoxFrameColor();
                battleCardObject.box_Frame.color = colorManager.GetOtsutsuki_BoxFrameColor();
                battleCardObject.effectText_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetOtsutsuki_TextColor();
                battleCardObject.effectTextIcon_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetOtsutsuki_TextColor();

                battleCardObject.head_Frame.color = colorManager.GetOtsutsuki_BoxFrameColor();
                battleCardObject.head_Amount.color = colorManager.GetOtsutsuki_TextColor();

                break;
            case Clan.Senju:
                battleCardObject.outerFrame.color = colorManager.GetSenju_BorderColor();
                battleCardObject.background_Image.color = colorManager.GetSenju_BackgroundColor();

                battleCardObject.over_Circle.color = colorManager.GetSenju_CircleColor();
                battleCardObject.over_Field.color = colorManager.GetSenju_BackgroundColor();
                battleCardObject.over_Frame.color = colorManager.GetSenju_BorderColor();
                battleCardObject.under_Circle.color = colorManager.GetSenju_CircleColor();
                battleCardObject.under_Field.color = colorManager.GetSenju_BackgroundColor();
                battleCardObject.under_Frame.color = colorManager.GetSenju_BorderColor();

                battleCardObject.landOrigins_Image.color = colorManager.GetSenju_LandOriginColor();

                battleCardObject.name_Text.color = colorManager.GetSenju_TextColor();
                battleCardObject.loreInfo_Text.color = colorManager.GetSenju_TextColor();

                battleCardObject.taijutsuValue_Text.color = colorManager.GetSenju_TextColor();
                battleCardObject.ninjutsuValue_Text.color = colorManager.GetSenju_TextColor();
                battleCardObject.genjutsuValue_Text.color = colorManager.GetSenju_TextColor();

                battleCardObject.Taijutsu_Border_Image.color = colorManager.GetSenju_BorderColor();
                battleCardObject.Ninjutsu_Border_Image.color = colorManager.GetSenju_BorderColor();
                battleCardObject.Genjutsu_Border_Image.color = colorManager.GetSenju_BorderColor();

                battleCardObject.focusArea_Frame.color = colorManager.GetSenju_BoxFrameColor();
                battleCardObject.box_Frame.color = colorManager.GetSenju_BoxFrameColor();
                battleCardObject.effectText_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetSenju_TextColor();
                battleCardObject.effectTextIcon_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetSenju_TextColor();

                battleCardObject.head_Frame.color = colorManager.GetSenju_BoxFrameColor();
                battleCardObject.head_Amount.color = colorManager.GetSenju_TextColor();

                break;
            case Clan.Uchiha:
                battleCardObject.outerFrame.color = colorManager.GetUchiha_BorderColor();
                battleCardObject.background_Image.color = colorManager.GetUchiha_BackgroundColor();

                battleCardObject.over_Circle.color = colorManager.GetUchiha_CircleColor();
                battleCardObject.over_Field.color = colorManager.GetUchiha_BackgroundColor();
                battleCardObject.over_Frame.color = colorManager.GetUchiha_BorderColor();
                battleCardObject.under_Circle.color = colorManager.GetUchiha_CircleColor();
                battleCardObject.under_Field.color = colorManager.GetUchiha_BackgroundColor();
                battleCardObject.under_Frame.color = colorManager.GetUchiha_BorderColor();

                battleCardObject.landOrigins_Image.color = colorManager.GetUchiha_LandOriginColor();

                battleCardObject.name_Text.color = colorManager.GetUchiha_TextColor();
                battleCardObject.loreInfo_Text.color = colorManager.GetUchiha_TextColor();

                battleCardObject.taijutsuValue_Text.color = colorManager.GetUchiha_TextColor();
                battleCardObject.ninjutsuValue_Text.color = colorManager.GetUchiha_TextColor();
                battleCardObject.genjutsuValue_Text.color = colorManager.GetUchiha_TextColor();

                battleCardObject.Taijutsu_Border_Image.color = colorManager.GetUchiha_BorderColor();
                battleCardObject.Ninjutsu_Border_Image.color = colorManager.GetUchiha_BorderColor();
                battleCardObject.Genjutsu_Border_Image.color = colorManager.GetUchiha_BorderColor();

                battleCardObject.focusArea_Frame.color = colorManager.GetUchiha_BoxFrameColor();
                battleCardObject.box_Frame.color = colorManager.GetUchiha_BoxFrameColor();
                battleCardObject.effectText_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetUchiha_TextColor();
                battleCardObject.effectTextIcon_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetUchiha_TextColor();

                battleCardObject.head_Frame.color = colorManager.GetUchiha_BoxFrameColor();
                battleCardObject.head_Amount.color = colorManager.GetUchiha_TextColor();

                break;
            case Clan.Uzumaki:
                battleCardObject.outerFrame.color = colorManager.GetUzumaki_BorderColor();
                battleCardObject.background_Image.color = colorManager.GetUzumaki_BackgroundColor();

                battleCardObject.over_Circle.color = colorManager.GetUzumaki_CircleColor();
                battleCardObject.over_Field.color = colorManager.GetUzumaki_BackgroundColor();
                battleCardObject.over_Frame.color = colorManager.GetUzumaki_BorderColor();
                battleCardObject.under_Circle.color = colorManager.GetUzumaki_CircleColor();
                battleCardObject.under_Field.color = colorManager.GetUzumaki_BackgroundColor();
                battleCardObject.under_Frame.color = colorManager.GetUzumaki_BorderColor();

                battleCardObject.landOrigins_Image.color = colorManager.GetUzumaki_LandOriginColor();

                battleCardObject.name_Text.color = colorManager.GetUzumaki_TextColor();
                battleCardObject.loreInfo_Text.color = colorManager.GetUzumaki_TextColor();

                battleCardObject.taijutsuValue_Text.color = colorManager.GetUzumaki_TextColor();
                battleCardObject.ninjutsuValue_Text.color = colorManager.GetUzumaki_TextColor();
                battleCardObject.genjutsuValue_Text.color = colorManager.GetUzumaki_TextColor();

                battleCardObject.Taijutsu_Border_Image.color = colorManager.GetUzumaki_BorderColor();
                battleCardObject.Ninjutsu_Border_Image.color = colorManager.GetUzumaki_BorderColor();
                battleCardObject.Genjutsu_Border_Image.color = colorManager.GetUzumaki_BorderColor();

                battleCardObject.focusArea_Frame.color = colorManager.GetUzumaki_BoxFrameColor();
                battleCardObject.box_Frame.color = colorManager.GetUzumaki_BoxFrameColor();
                battleCardObject.effectText_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetUzumaki_TextColor();
                battleCardObject.effectTextIcon_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetUzumaki_TextColor();

                battleCardObject.head_Frame.color = colorManager.GetUzumaki_BoxFrameColor();
                battleCardObject.head_Amount.color = colorManager.GetUzumaki_TextColor();

                break;
            case Clan.Kara:
                battleCardObject.outerFrame.color = colorManager.GetKara_BorderColor();
                battleCardObject.background_Image.color = colorManager.GetKara_BackgroundColor();

                battleCardObject.over_Circle.color = colorManager.GetKara_CircleColor();
                battleCardObject.over_Field.color = colorManager.GetKara_BackgroundColor();
                battleCardObject.over_Frame.color = colorManager.GetKara_BorderColor();
                battleCardObject.under_Circle.color = colorManager.GetKara_CircleColor();
                battleCardObject.under_Field.color = colorManager.GetKara_BackgroundColor();
                battleCardObject.under_Frame.color = colorManager.GetKara_BorderColor();

                battleCardObject.landOrigins_Image.color = colorManager.GetKara_LandOriginColor();

                battleCardObject.name_Text.color = colorManager.GetKara_TextColor();
                battleCardObject.loreInfo_Text.color = colorManager.GetKara_TextColor();

                battleCardObject.taijutsuValue_Text.color = colorManager.GetKara_TextColor();
                battleCardObject.ninjutsuValue_Text.color = colorManager.GetKara_TextColor();
                battleCardObject.genjutsuValue_Text.color = colorManager.GetKara_TextColor();

                battleCardObject.Taijutsu_Border_Image.color = colorManager.GetKara_BorderColor();
                battleCardObject.Ninjutsu_Border_Image.color = colorManager.GetKara_BorderColor();
                battleCardObject.Genjutsu_Border_Image.color = colorManager.GetKara_BorderColor();

                battleCardObject.focusArea_Frame.color = colorManager.GetKara_BoxFrameColor();
                battleCardObject.box_Frame.color = colorManager.GetKara_BoxFrameColor();
                battleCardObject.effectText_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetKara_TextColor();
                battleCardObject.effectTextIcon_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetKara_TextColor();

                battleCardObject.head_Frame.color = colorManager.GetKara_BoxFrameColor();
                battleCardObject.head_Amount.color = colorManager.GetKara_TextColor();

                break;
            case Clan.Ally:
                battleCardObject.outerFrame.color = colorManager.GetAlly_BorderColor();
                battleCardObject.background_Image.color = colorManager.GetAlly_BackgroundColor();

                battleCardObject.over_Circle.color = colorManager.GetAlly_CircleColor();
                battleCardObject.over_Field.color = colorManager.GetAlly_BackgroundColor();
                battleCardObject.over_Frame.color = colorManager.GetAlly_BorderColor();
                battleCardObject.under_Circle.color = colorManager.GetAlly_CircleColor();
                battleCardObject.under_Field.color = colorManager.GetAlly_BackgroundColor();
                battleCardObject.under_Frame.color = colorManager.GetAlly_BorderColor();

                battleCardObject.landOrigins_Image.color = colorManager.GetAlly_LandOriginColor();

                battleCardObject.name_Text.color = colorManager.GetAlly_TextColor();
                battleCardObject.loreInfo_Text.color = colorManager.GetAlly_TextColor();

                battleCardObject.taijutsuValue_Text.color = colorManager.GetAlly_TextColor();
                battleCardObject.ninjutsuValue_Text.color = colorManager.GetAlly_TextColor();
                battleCardObject.genjutsuValue_Text.color = colorManager.GetAlly_TextColor();

                battleCardObject.Taijutsu_Border_Image.color = colorManager.GetAlly_BorderColor();
                battleCardObject.Ninjutsu_Border_Image.color = colorManager.GetAlly_BorderColor();
                battleCardObject.Genjutsu_Border_Image.color = colorManager.GetAlly_BorderColor();

                battleCardObject.focusArea_Frame.color = colorManager.GetAlly_BoxFrameColor();
                battleCardObject.box_Frame.color = colorManager.GetAlly_BoxFrameColor();
                battleCardObject.effectText_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetAlly_TextColor();
                battleCardObject.effectTextIcon_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetAlly_TextColor();

                battleCardObject.head_Frame.color = colorManager.GetAlly_BoxFrameColor();
                battleCardObject.head_Amount.color = colorManager.GetAlly_TextColor();

                break;
            case Clan.Ally_Rare:
                battleCardObject.outerFrame.color = colorManager.GetAlly_BorderColor();
                battleCardObject.background_Image.color = colorManager.GetAlly_BackgroundColor();

                battleCardObject.over_Circle.color = colorManager.GetAlly_CircleColor();
                battleCardObject.over_Field.color = colorManager.GetAlly_BackgroundColor();
                battleCardObject.over_Frame.color = colorManager.GetAlly_BorderColor();
                battleCardObject.under_Circle.color = colorManager.GetAlly_CircleColor();
                battleCardObject.under_Field.color = colorManager.GetAlly_BackgroundColor();
                battleCardObject.under_Frame.color = colorManager.GetAlly_BorderColor();

                battleCardObject.landOrigins_Image.color = colorManager.GetAlly_LandOriginColor();

                battleCardObject.name_Text.color = colorManager.GetAlly_TextColor();
                battleCardObject.loreInfo_Text.color = colorManager.GetAlly_TextColor();

                battleCardObject.taijutsuValue_Text.color = colorManager.GetAlly_TextColor();
                battleCardObject.ninjutsuValue_Text.color = colorManager.GetAlly_TextColor();
                battleCardObject.genjutsuValue_Text.color = colorManager.GetAlly_TextColor();

                battleCardObject.Taijutsu_Border_Image.color = colorManager.GetAlly_BorderColor();
                battleCardObject.Ninjutsu_Border_Image.color = colorManager.GetAlly_BorderColor();
                battleCardObject.Genjutsu_Border_Image.color = colorManager.GetAlly_BorderColor();

                battleCardObject.focusArea_Frame.color = colorManager.GetAlly_BoxFrameColor();
                battleCardObject.box_Frame.color = colorManager.GetAlly_BoxFrameColor();
                battleCardObject.effectText_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetAlly_TextColor();
                battleCardObject.effectTextIcon_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetAlly_TextColor();

                battleCardObject.head_Frame.color = colorManager.GetAlly_BoxFrameColor();
                battleCardObject.head_Amount.color = colorManager.GetAlly_TextColor();

                break;
            case Clan.Ally_Epic:
                battleCardObject.outerFrame.color = colorManager.GetAlly_BorderColor();
                battleCardObject.background_Image.color = colorManager.GetAlly_BackgroundColor();

                battleCardObject.over_Circle.color = colorManager.GetAlly_CircleColor();
                battleCardObject.over_Field.color = colorManager.GetAlly_BackgroundColor();
                battleCardObject.over_Frame.color = colorManager.GetAlly_BorderColor();
                battleCardObject.under_Circle.color = colorManager.GetAlly_CircleColor();
                battleCardObject.under_Field.color = colorManager.GetAlly_BackgroundColor();
                battleCardObject.under_Frame.color = colorManager.GetAlly_BorderColor();

                battleCardObject.landOrigins_Image.color = colorManager.GetAlly_LandOriginColor();

                battleCardObject.name_Text.color = colorManager.GetAlly_TextColor();
                battleCardObject.loreInfo_Text.color = colorManager.GetAlly_TextColor();

                battleCardObject.taijutsuValue_Text.color = colorManager.GetAlly_TextColor();
                battleCardObject.ninjutsuValue_Text.color = colorManager.GetAlly_TextColor();
                battleCardObject.genjutsuValue_Text.color = colorManager.GetAlly_TextColor();

                battleCardObject.Taijutsu_Border_Image.color = colorManager.GetAlly_BorderColor();
                battleCardObject.Ninjutsu_Border_Image.color = colorManager.GetAlly_BorderColor();
                battleCardObject.Genjutsu_Border_Image.color = colorManager.GetAlly_BorderColor();

                battleCardObject.focusArea_Frame.color = colorManager.GetAlly_BoxFrameColor();
                battleCardObject.box_Frame.color = colorManager.GetAlly_BoxFrameColor();
                battleCardObject.effectText_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetAlly_TextColor();
                battleCardObject.effectTextIcon_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetAlly_TextColor();

                battleCardObject.head_Frame.color = colorManager.GetAlly_BoxFrameColor();
                battleCardObject.head_Amount.color = colorManager.GetAlly_TextColor();

                break;
            case Clan.Ally_Legendary:
                battleCardObject.outerFrame.color = colorManager.GetAlly_BorderColor();
                battleCardObject.background_Image.color = colorManager.GetAlly_BackgroundColor();

                battleCardObject.over_Circle.color = colorManager.GetAlly_CircleColor();
                battleCardObject.over_Field.color = colorManager.GetAlly_BackgroundColor();
                battleCardObject.over_Frame.color = colorManager.GetAlly_BorderColor();
                battleCardObject.under_Circle.color = colorManager.GetAlly_CircleColor();
                battleCardObject.under_Field.color = colorManager.GetAlly_BackgroundColor();
                battleCardObject.under_Frame.color = colorManager.GetAlly_BorderColor();

                battleCardObject.landOrigins_Image.color = colorManager.GetAlly_LandOriginColor();

                battleCardObject.name_Text.color = colorManager.GetAlly_TextColor();
                battleCardObject.loreInfo_Text.color = colorManager.GetAlly_TextColor();

                battleCardObject.taijutsuValue_Text.color = colorManager.GetAlly_TextColor();
                battleCardObject.ninjutsuValue_Text.color = colorManager.GetAlly_TextColor();
                battleCardObject.genjutsuValue_Text.color = colorManager.GetAlly_TextColor();

                battleCardObject.Taijutsu_Border_Image.color = colorManager.GetAlly_BorderColor();
                battleCardObject.Ninjutsu_Border_Image.color = colorManager.GetAlly_BorderColor();
                battleCardObject.Genjutsu_Border_Image.color = colorManager.GetAlly_BorderColor();

                battleCardObject.focusArea_Frame.color = colorManager.GetAlly_BoxFrameColor();
                battleCardObject.box_Frame.color = colorManager.GetAlly_BoxFrameColor();
                battleCardObject.effectText_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetAlly_TextColor();
                battleCardObject.effectTextIcon_Parent.GetComponentInChildren<TextMeshProUGUI>().color = colorManager.GetAlly_TextColor();

                battleCardObject.head_Frame.color = colorManager.GetAlly_BoxFrameColor();
                battleCardObject.head_Amount.color = colorManager.GetAlly_TextColor();

                break;
            default:
                break;
        }

        //Name Box
        battleCardObject.name_Text.text = battleCard.name;
        battleCardObject.loreInfo_Text.text = "- " + battleCard.loreInfo + " -";

        //Land Origin Sprite
        switch (battleCard.landOrigins)
        {
            case landOrigins.None:
                battleCardObject.landOrigins_Image.sprite = null;
                break;
            case landOrigins.ANBU:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_ANBU;
                break;
            case landOrigins.Cliff:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Cliff;
                break;
            case landOrigins.Cloud:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Cloud;
                break;
            case landOrigins.Craftsmen:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Craftsmen;
                break;
            case landOrigins.Curtain:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Curtain;
                break;
            case landOrigins.Dawn:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Dawn;
                break;
            case landOrigins.Eddy:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Eddy;
                break;
            case landOrigins.Fields:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Fields;
                break;
            case landOrigins.Grass:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Grass;
                break;
            case landOrigins.Hawk:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Hawk;
                break;
            case landOrigins.Haze:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Haze;
                break;
            case landOrigins.HotWater:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_HotWater;
                break;
            case landOrigins.Iron:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Iron;
                break;
            case landOrigins.JiroIsland:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_JiroIsland;
                break;
            case landOrigins.KikaIsland:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_KikaIsland;
                break;
            case landOrigins.LandOfAncestors:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_LandOfAncestors;
                break;
            case landOrigins.Leaf:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Leaf;
                break;
            case landOrigins.Lock:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Lock;
                break;
            case landOrigins.Mines:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Mines;
                break;
            case landOrigins.Mist:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Mist;
                break;
            case landOrigins.Moon:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Moon;
                break;
            case landOrigins.MountMyoboku:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_MountMyoboku;
                break;
            case landOrigins.Mountain:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Mountain;
                break;
            case landOrigins.Noodles:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Noodles;
                break;
            case landOrigins.Rain:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Rain;
                break;
            case landOrigins.Rice:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Rice;
                break;
            case landOrigins.River:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_River;
                break;
            case landOrigins.Sand:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Sand;
                break;
            case landOrigins.Sea:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Sea;
                break;
            case landOrigins.Sky:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Sky;
                break;
            case landOrigins.Snow:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Snow;
                break;
            case landOrigins.Sound:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Sound;
                break;
            case landOrigins.Star:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Star;
                break;
            case landOrigins.Stone:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Stone;
                break;
            case landOrigins.Tea:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Tea;
                break;
            case landOrigins.ThreeTunders:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_ThreeTunders;
                break;
            case landOrigins.TurtleIsland:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_TurtleIsland;
                break;
            case landOrigins.Vegetable:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Vegetable;
                break;
            case landOrigins.Waterfall:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Waterfall;
                break;
            case landOrigins.Wave:
                battleCardObject.landOrigins_Image.sprite = NationSymbol_Wave;
                break;

            default:
                battleCardObject.landOrigins_Image.sprite = null;
                break;
        }

        //Character Sprite
        battleCardObject.characterImage.sprite = battleCard.characterSprite;

        //Values
        #region
        if (battleCard.TaijutsuValue > 0)
        {
            battleCardObject.Taijutsu_Border_Image.gameObject.SetActive(true);
            battleCardObject.Taijutsu_Border_BG.gameObject.SetActive(true);
            battleCardObject.taijutsuValue_Text.gameObject.SetActive(true);

            battleCardObject.taijutsuValue_Text.text = battleCard.TaijutsuValue.ToString();
        }
        else
        {
            battleCardObject.Taijutsu_Border_Image.gameObject.SetActive(false);
            battleCardObject.Taijutsu_Border_BG.gameObject.SetActive(false);
            battleCardObject.taijutsuValue_Text.gameObject.SetActive(false);
        }

        if (battleCard.NinjutsuValue > 0)
        {
            battleCardObject.Ninjutsu_Border_Image.gameObject.SetActive(true);
            battleCardObject.Ninjutsu_Border_BG.gameObject.SetActive(true);
            battleCardObject.ninjutsuValue_Text.gameObject.SetActive(true);

            battleCardObject.ninjutsuValue_Text.text = battleCard.NinjutsuValue.ToString();
        }
        else
        {
            battleCardObject.Ninjutsu_Border_Image.gameObject.SetActive(false);
            battleCardObject.Ninjutsu_Border_BG.gameObject.SetActive(false);
            battleCardObject.ninjutsuValue_Text.gameObject.SetActive(false);
        }

        if (battleCard.GenjutsuValue > 0)
        {
            battleCardObject.Genjutsu_Border_Image.gameObject.SetActive(true);
            battleCardObject.Genjutsu_Border_BG.gameObject.SetActive(true);
            battleCardObject.genjutsuValue_Text.gameObject.SetActive(true);

            battleCardObject.genjutsuValue_Text.text = battleCard.GenjutsuValue.ToString();
        }
        else
        {
            battleCardObject.Genjutsu_Border_Image.gameObject.SetActive(false);
            battleCardObject.Genjutsu_Border_BG.gameObject.SetActive(false);
            battleCardObject.genjutsuValue_Text.gameObject.SetActive(false);
        }
        #endregion

        //Heal
        switch (battleCard.heal)
        {
            case Heal.None:
                battleCardObject.healParent.SetActive(false);
                battleCardObject.healBlockParent.SetActive(false);
                battleCardObject.over_Circle.sprite = circle_Empty;
                break;
            case Heal.Heal:
                battleCardObject.healParent.SetActive(true);
                battleCardObject.healBlockParent.SetActive(false);
                battleCardObject.over_Circle.sprite = circle_Heal;
                break;
            case Heal.HealBlock:
                battleCardObject.healParent.SetActive(false);
                battleCardObject.healBlockParent.SetActive(true);
                battleCardObject.over_Circle.sprite = circle_HealBlock;
                break;

            default:
                break;
        }

        //Tailed Beast Heads
        #region
        if (battleCard.headAmount > 0)
        {
            if (CardDisplayManager.Instance.focusIcon)
            {
                battleCardObject.headParent.transform.localPosition = new Vector2(-574, -31);
            }
            else
            {
                battleCardObject.headParent.transform.localPosition = new Vector2(-574, -167);
            }

            battleCardObject.headParent.SetActive(true);
        }
        else
        {
            battleCardObject.headParent.SetActive(false);
        }

        battleCardObject.head_Amount.text = battleCard.headAmount.ToString();
        #endregion

        //Focus Area
        #region
        battleCardObject.focusArea_Image.color = Color.white;

        if (CardDisplayManager.Instance.focusIcon)
        {
            battleCardObject.focusArea_Parent.SetActive(true);

            switch (battleCard.focusArea)
            {
                //None
                case FocusArea.None:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_None;
                    break;

                //Cards
                case FocusArea.ActionCards:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_ActionCards;
                    break;
                case FocusArea.ClanCards:

                    switch (battleCard.clan)
                    {
                        case Clan.None:
                            battleCardObject.focusArea_Image.sprite = battleCardObject.focus_ClanCards_All;
                            break;

                        case Clan.Akatsuki_Awakening:
                            battleCardObject.focusArea_Image.sprite = battleCardObject.focus_ClanCards_Akatsuki;
                            break;
                        case Clan.Akatsuki:
                            battleCardObject.focusArea_Image.sprite = battleCardObject.focus_ClanCards_Akatsuki;
                            break;
                        case Clan.Hyuga:
                            battleCardObject.focusArea_Image.sprite = battleCardObject.focus_ClanCards_Hyuga;
                            break;
                        case Clan.Otsutsuki:
                            battleCardObject.focusArea_Image.sprite = battleCardObject.focus_ClanCards_Otsutsuki;
                            break;
                        case Clan.Senju:
                            battleCardObject.focusArea_Image.sprite = battleCardObject.focus_ClanCards_Senju;
                            break;
                        case Clan.Uchiha:
                            battleCardObject.focusArea_Image.sprite = battleCardObject.focus_ClanCards_Uchiha;
                            break;
                        case Clan.Uzumaki:
                            battleCardObject.focusArea_Image.sprite = battleCardObject.focus_ClanCards_Uzumaki;
                            break;
                        case Clan.Kara:
                            battleCardObject.focusArea_Image.sprite = battleCardObject.focus_ClanCards_Kara;
                            break;
                        case Clan.Ally:
                            battleCardObject.focusArea_Image.sprite = battleCardObject.focus_ClanCards_All;
                            break;
                        case Clan.Ally_Rare:
                            battleCardObject.focusArea_Image.sprite = battleCardObject.focus_ClanCards_All;
                            break;
                        case Clan.Ally_Epic:
                            battleCardObject.focusArea_Image.sprite = battleCardObject.focus_ClanCards_All;
                            break;
                        case Clan.Ally_Legendary:
                            battleCardObject.focusArea_Image.sprite = battleCardObject.focus_ClanCards_All;
                            break;

                        default:
                            break;
                    }
                    break;
                case FocusArea.AwakeningCards:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_AwakeningCards;
                    break;
                case FocusArea.BattleCards:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_BattleCards;
                    break;
                case FocusArea.BattleCards_All:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_BattleCards_All;
                    break;
                case FocusArea.EventCards:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_EventCards;
                    break;

                case FocusArea.Ally_Rare:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Ally_Rare;
                    break;
                case FocusArea.Ally_Epic:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Ally_Epic;
                    break;
                case FocusArea.Ally_Legendary:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Ally_Legendary;
                    break;
                case FocusArea.Ally_RareEpic:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Ally_RareEpic;
                    break;
                case FocusArea.Ally_RareLegendary:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Ally_RareLegendary;
                    break;
                case FocusArea.Ally_EpicLegendary:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Ally_EpicLegendary;
                    break;
                case FocusArea.Ally_All:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Ally_All;
                    break;

                //Effect Tokens
                case FocusArea.Effect_Poison:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Effect_Poison;
                    break;
                case FocusArea.Effect_Paralyse:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Effect_Paralyse;
                    break;
                case FocusArea.Effect_Illusion:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Effect_Illusion;
                    break;
                case FocusArea.Effect_Freeze:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Effect_Freeze;
                    break;
                case FocusArea.Effect_Chain:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Effect_Chain;
                    break;
                case FocusArea.Effect_Substitution:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Effect_Substitution;
                    break;
                case FocusArea.Effect_All:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Effect_All;
                    break;
                case FocusArea.Effect_All_MinusChain:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Effect_All_MinusChain;
                    break;
                case FocusArea.Effect_All_MinusSubstitution:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.Effect_All_MinusSubstitution;
                    break;
                case FocusArea.Effect_All_MinusChain_and_Substitution:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.Effect_All_MinusChain_and_Substitution;
                    break;
                case FocusArea.Effect_Paralyse_And_Illusion:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Effect_Paralyse_and_Illusion;
                    break;
                case FocusArea.Effect_Freeze_and_Paralyze:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Effect_Freeze_and_Paralyze;
                    break;

                //Merged
                case FocusArea.Merged_Coin_And_Illusion:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Merged_Coin_and_Illusion;
                    break;

                //Coin
                case FocusArea.Coin:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Coin;
                    break;

                //Tailed Beast
                case FocusArea.TailedBeast:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_TailedBeast;
                    break;
                case FocusArea.TailedBeastBuff:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_TailedBeastBuff;
                    break;

                //Units
                case FocusArea.Units:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Units;

                    switch (battleCard.clan)
                    {
                        case Clan.None:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;

                        case Clan.Akatsuki_Awakening:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;
                        case Clan.Akatsuki:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;
                        case Clan.Hyuga:
                            battleCardObject.focusArea_Image.color = colorManager.GetHyuga_BoxFrameColor();
                            break;
                        case Clan.Otsutsuki:
                            battleCardObject.focusArea_Image.color = colorManager.GetOtsutsuki_BoxFrameColor();
                            break;
                        case Clan.Senju:
                            battleCardObject.focusArea_Image.color = colorManager.GetSenju_BoxFrameColor();
                            break;
                        case Clan.Uchiha:
                            battleCardObject.focusArea_Image.color = colorManager.GetUchiha_BoxFrameColor();
                            break;
                        case Clan.Uzumaki:
                            battleCardObject.focusArea_Image.color = colorManager.GetUzumaki_BoxFrameColor();
                            break;
                        case Clan.Kara:
                            battleCardObject.focusArea_Image.color = colorManager.GetKara_BoxFrameColor();
                            break;
                        case Clan.Ally:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;
                        case Clan.Ally_Rare:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;
                        case Clan.Ally_Epic:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;
                        case Clan.Ally_Legendary:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;

                        default:
                            break;
                    }
                    break;
                case FocusArea.Boats:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Boats;

                    switch (battleCard.clan)
                    {
                        case Clan.None:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;

                        case Clan.Akatsuki_Awakening:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;
                        case Clan.Akatsuki:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;
                        case Clan.Hyuga:
                            battleCardObject.focusArea_Image.color = colorManager.GetHyuga_BoxFrameColor();
                            break;
                        case Clan.Otsutsuki:
                            battleCardObject.focusArea_Image.color = colorManager.GetOtsutsuki_BoxFrameColor();
                            break;
                        case Clan.Senju:
                            battleCardObject.focusArea_Image.color = colorManager.GetSenju_BoxFrameColor();
                            break;
                        case Clan.Uchiha:
                            battleCardObject.focusArea_Image.color = colorManager.GetUchiha_BoxFrameColor();
                            break;
                        case Clan.Uzumaki:
                            battleCardObject.focusArea_Image.color = colorManager.GetUzumaki_BoxFrameColor();
                            break;
                        case Clan.Kara:
                            battleCardObject.focusArea_Image.color = colorManager.GetKara_BoxFrameColor();
                            break;
                        case Clan.Ally:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;
                        case Clan.Ally_Rare:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;
                        case Clan.Ally_Epic:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;
                        case Clan.Ally_Legendary:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;

                        default:
                            break;
                    }
                    break;

                //Dominance Track
                case FocusArea.Dominance_UP:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Dominance_UP;
                    break;
                case FocusArea.Dominance_DOWN:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Dominance_DOWN;
                    break;
                case FocusArea.Dominance_UpDown:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Dominance_UpDown;
                    break;

                case FocusArea.Dominance_Weights:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Dominance_Weights;
                    break;
                case FocusArea.Dominance_TieBreaker:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Dominance_TieBreaker;
                    break;
                case FocusArea.Dominance_UnitStrength:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Dominance_UnitStrength;
                    break;
                case FocusArea.Dominance_Recruitment:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Dominance_Recruitment;
                    break;
                case FocusArea.Dominance_Payment:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Dominance_Payment;
                    break;
                case FocusArea.Dominance_HandLimit:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Dominance_HandLimit;
                    break;

                //Heal
                case FocusArea.Heal:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Heal;
                    break;
                case FocusArea.HealBlock:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_HealBlock;
                    break;

                //Effect Icons
                case FocusArea.Skull:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Skull;
                    break;
                case FocusArea.Sand:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Sand;
                    break;
                case FocusArea.Skull_Sand:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Skull_Sand;
                    break;

                //Reroll
                case FocusArea.Reroll:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Reroll;
                    break;

                //War
                case FocusArea.War:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_War;
                    break;
                case FocusArea.Battle:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Battle;
                    break;
                case FocusArea.BattlePoint:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_BattlePoint;

                    switch (battleCard.clan)
                    {
                        case Clan.None:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_TextColor();
                            break;

                        case Clan.Akatsuki_Awakening:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_TextColor();
                            break;
                        case Clan.Akatsuki:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_TextColor();
                            break;
                        case Clan.Hyuga:
                            battleCardObject.focusArea_Image.color = colorManager.GetHyuga_TextColor();
                            break;
                        case Clan.Otsutsuki:
                            battleCardObject.focusArea_Image.color = colorManager.GetOtsutsuki_TextColor();
                            break;
                        case Clan.Senju:
                            battleCardObject.focusArea_Image.color = colorManager.GetSenju_TextColor();
                            break;
                        case Clan.Uchiha:
                            battleCardObject.focusArea_Image.color = colorManager.GetUchiha_TextColor();
                            break;
                        case Clan.Uzumaki:
                            battleCardObject.focusArea_Image.color = colorManager.GetUzumaki_TextColor();
                            break;
                        case Clan.Kara:
                            battleCardObject.focusArea_Image.color = colorManager.GetKara_TextColor();
                            break;
                        case Clan.Ally:
                            battleCardObject.focusArea_Image.color = colorManager.GetAlly_TextColor();
                            break;
                        case Clan.Ally_Rare:
                            battleCardObject.focusArea_Image.color = colorManager.GetAlly_TextColor();
                            break;
                        case Clan.Ally_Epic:
                            battleCardObject.focusArea_Image.color = colorManager.GetAlly_TextColor();
                            break;
                        case Clan.Ally_Legendary:
                            battleCardObject.focusArea_Image.color = colorManager.GetAlly_TextColor();
                            break;

                        default:
                            break;
                    }
                    break;
                case FocusArea.CombatStrength:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_CombatStrength;

                    switch (battleCard.clan)
                    {
                        case Clan.None:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;

                        case Clan.Akatsuki_Awakening:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;
                        case Clan.Akatsuki:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;
                        case Clan.Hyuga:
                            battleCardObject.focusArea_Image.color = colorManager.GetHyuga_BoxFrameColor();
                            break;
                        case Clan.Otsutsuki:
                            battleCardObject.focusArea_Image.color = colorManager.GetOtsutsuki_BorderColor();
                            break;
                        case Clan.Senju:
                            battleCardObject.focusArea_Image.color = colorManager.GetSenju_BoxFrameColor();
                            break;
                        case Clan.Uchiha:
                            battleCardObject.focusArea_Image.color = colorManager.GetUchiha_BoxFrameColor();
                            break;
                        case Clan.Uzumaki:
                            battleCardObject.focusArea_Image.color = colorManager.GetUzumaki_BoxFrameColor();
                            break;
                        case Clan.Kara:
                            battleCardObject.focusArea_Image.color = colorManager.GetKara_BoxFrameColor();
                            break;
                        case Clan.Ally:
                            battleCardObject.focusArea_Image.color = colorManager.GetAlly_BoxFrameColor();
                            break;
                        case Clan.Ally_Rare:
                            battleCardObject.focusArea_Image.color = colorManager.GetAlly_BoxFrameColor();
                            break;
                        case Clan.Ally_Epic:
                            battleCardObject.focusArea_Image.color = colorManager.GetAlly_BoxFrameColor();
                            break;
                        case Clan.Ally_Legendary:
                            battleCardObject.focusArea_Image.color = colorManager.GetAlly_BoxFrameColor();
                            break;

                        default:
                            break;
                    }
                    break;
                case FocusArea.Effect:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Effect;

                    switch (battleCard.clan)
                    {
                        case Clan.None:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;

                        case Clan.Akatsuki_Awakening:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;
                        case Clan.Akatsuki:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;
                        case Clan.Hyuga:
                            battleCardObject.focusArea_Image.color = colorManager.GetHyuga_BoxFrameColor();
                            break;
                        case Clan.Otsutsuki:
                            battleCardObject.focusArea_Image.color = colorManager.GetOtsutsuki_BorderColor();
                            break;
                        case Clan.Senju:
                            battleCardObject.focusArea_Image.color = colorManager.GetSenju_BoxFrameColor();
                            break;
                        case Clan.Uchiha:
                            battleCardObject.focusArea_Image.color = colorManager.GetUchiha_BoxFrameColor();
                            break;
                        case Clan.Uzumaki:
                            battleCardObject.focusArea_Image.color = colorManager.GetUzumaki_BoxFrameColor();
                            break;
                        case Clan.Kara:
                            battleCardObject.focusArea_Image.color = colorManager.GetKara_BoxFrameColor();
                            break;
                        case Clan.Ally:
                            battleCardObject.focusArea_Image.color = colorManager.GetAlly_BoxFrameColor();
                            break;
                        case Clan.Ally_Rare:
                            battleCardObject.focusArea_Image.color = colorManager.GetAlly_BoxFrameColor();
                            break;
                        case Clan.Ally_Epic:
                            battleCardObject.focusArea_Image.color = colorManager.GetAlly_BoxFrameColor();
                            break;
                        case Clan.Ally_Legendary:
                            battleCardObject.focusArea_Image.color = colorManager.GetAlly_BoxFrameColor();
                            break;

                        default:
                            break;
                    }
                    break;
                case FocusArea.Resources:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Resources;

                    switch (battleCard.clan)
                    {
                        case Clan.None:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;

                        case Clan.Akatsuki_Awakening:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;
                        case Clan.Akatsuki:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;
                        case Clan.Hyuga:
                            battleCardObject.focusArea_Image.color = colorManager.GetHyuga_BoxFrameColor();
                            break;
                        case Clan.Otsutsuki:
                            battleCardObject.focusArea_Image.color = colorManager.GetOtsutsuki_BorderColor();
                            break;
                        case Clan.Senju:
                            battleCardObject.focusArea_Image.color = colorManager.GetSenju_BoxFrameColor();
                            break;
                        case Clan.Uchiha:
                            battleCardObject.focusArea_Image.color = colorManager.GetUchiha_BoxFrameColor();
                            break;
                        case Clan.Uzumaki:
                            battleCardObject.focusArea_Image.color = colorManager.GetUzumaki_BoxFrameColor();
                            break;
                        case Clan.Kara:
                            battleCardObject.focusArea_Image.color = colorManager.GetKara_BoxFrameColor();
                            break;
                        case Clan.Ally:
                            battleCardObject.focusArea_Image.color = colorManager.GetAlly_BoxFrameColor();
                            break;
                        case Clan.Ally_Rare:
                            battleCardObject.focusArea_Image.color = colorManager.GetAlly_BoxFrameColor();
                            break;
                        case Clan.Ally_Epic:
                            battleCardObject.focusArea_Image.color = colorManager.GetAlly_BoxFrameColor();
                            break;
                        case Clan.Ally_Legendary:
                            battleCardObject.focusArea_Image.color = colorManager.GetAlly_BoxFrameColor();
                            break;

                        default:
                            break;
                    }
                    break;
                case FocusArea.Effect_And_Resources:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Effect_And_Resources;

                    switch (battleCard.clan)
                    {
                        case Clan.None:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;

                        case Clan.Akatsuki_Awakening:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;
                        case Clan.Akatsuki:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;
                        case Clan.Hyuga:
                            battleCardObject.focusArea_Image.color = colorManager.GetHyuga_BoxFrameColor();
                            break;
                        case Clan.Otsutsuki:
                            battleCardObject.focusArea_Image.color = colorManager.GetOtsutsuki_BorderColor();
                            break;
                        case Clan.Senju:
                            battleCardObject.focusArea_Image.color = colorManager.GetSenju_BoxFrameColor();
                            break;
                        case Clan.Uchiha:
                            battleCardObject.focusArea_Image.color = colorManager.GetUchiha_BoxFrameColor();
                            break;
                        case Clan.Uzumaki:
                            battleCardObject.focusArea_Image.color = colorManager.GetUzumaki_BoxFrameColor();
                            break;
                        case Clan.Kara:
                            battleCardObject.focusArea_Image.color = colorManager.GetKara_BoxFrameColor();
                            break;
                        case Clan.Ally:
                            battleCardObject.focusArea_Image.color = colorManager.GetAlly_BoxFrameColor();
                            break;
                        case Clan.Ally_Rare:
                            battleCardObject.focusArea_Image.color = colorManager.GetAlly_BoxFrameColor();
                            break;
                        case Clan.Ally_Epic:
                            battleCardObject.focusArea_Image.color = colorManager.GetAlly_BoxFrameColor();
                            break;
                        case Clan.Ally_Legendary:
                            battleCardObject.focusArea_Image.color = colorManager.GetAlly_BoxFrameColor();
                            break;

                        default:
                            break;
                    }
                    break;
                case FocusArea.Support:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Support;
                    break;

                case FocusArea.Immune:
                    battleCardObject.focusArea_Image.sprite = battleCardObject.focus_Immune;

                    switch (battleCard.clan)
                    {
                        case Clan.None:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;

                        case Clan.Akatsuki_Awakening:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;
                        case Clan.Akatsuki:
                            battleCardObject.focusArea_Image.color = colorManager.GetAkatsuki_BoxFrameColor();
                            break;
                        case Clan.Hyuga:
                            battleCardObject.focusArea_Image.color = colorManager.GetHyuga_BoxFrameColor();
                            break;
                        case Clan.Otsutsuki:
                            battleCardObject.focusArea_Image.color = colorManager.GetOtsutsuki_BorderColor();
                            break;
                        case Clan.Senju:
                            battleCardObject.focusArea_Image.color = colorManager.GetSenju_BoxFrameColor();
                            break;
                        case Clan.Uchiha:
                            battleCardObject.focusArea_Image.color = colorManager.GetUchiha_BoxFrameColor();
                            break;
                        case Clan.Uzumaki:
                            battleCardObject.focusArea_Image.color = colorManager.GetUzumaki_BoxFrameColor();
                            break;
                        case Clan.Kara:
                            battleCardObject.focusArea_Image.color = colorManager.GetKara_BoxFrameColor();
                            break;
                        case Clan.Ally:
                            battleCardObject.focusArea_Image.color = colorManager.GetAlly_BoxFrameColor();
                            break;
                        case Clan.Ally_Rare:
                            battleCardObject.focusArea_Image.color = colorManager.GetAlly_BoxFrameColor();
                            break;
                        case Clan.Ally_Epic:
                            battleCardObject.focusArea_Image.color = colorManager.GetAlly_BoxFrameColor();
                            break;
                        case Clan.Ally_Legendary:
                            battleCardObject.focusArea_Image.color = colorManager.GetAlly_BoxFrameColor();
                            break;

                        default:
                            break;
                    }
                    break;

                default:
                    break;
            }

            //Change to Clipped Frames
            battleCardObject.box_Frame.sprite = boxHead_Frame_Sprite;
            battleCardObject.box_Background.sprite = boxHead_Background_Sprite;
        }
        else
        {
            if (battleCard.headAmount > 0)
            {
                //Change to Whole Frames
                battleCardObject.box_Frame.sprite = boxHead_Frame_Sprite;
                battleCardObject.box_Background.sprite = boxHead_Background_Sprite;
            }
            else
            {

                //Change to Whole Frames
                battleCardObject.box_Frame.sprite = box_Frame_Sprite;
                battleCardObject.box_Background.sprite = box_Background_Sprite;
            }

            battleCardObject.focusArea_Parent.SetActive(false);
        }
        #endregion

        //Effect
        #region States
        //  - States - Change the size of box based on the amount of States
        //for (int j = 0; j < battleCardObject.states_Image.Count; j++)
        //    battleCardObject.states_Image[j].SetActive(true);
        //switch (battleCard.effectState.Count)
        //{
        //    case 0:
        //        battleCardObject.states_Parent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);
        //        for (int j = 0; j < battleCardObject.states_Image.Count; j++)
        //            battleCardObject.states_Image[j].SetActive(false);
        //        break;
        //    case 1:
        //        battleCardObject.states_Parent.GetComponent<RectTransform>().sizeDelta = new Vector2(120, 120);
        //        for (int j = 1; j < battleCardObject.states_Image.Count; j++)
        //            battleCardObject.states_Image[j].SetActive(false);
        //        break;
        //    case 2:
        //        battleCardObject.states_Parent.GetComponent<RectTransform>().sizeDelta = new Vector2(280, 120);
        //        for (int j = 2; j < battleCardObject.states_Image.Count; j++)
        //            battleCardObject.states_Image[j].SetActive(false);
        //        break;
        //    case 3:
        //        battleCardObject.states_Parent.GetComponent<RectTransform>().sizeDelta = new Vector2(440, 120);
        //        for (int j = 3; j < battleCardObject.states_Image.Count; j++)
        //            battleCardObject.states_Image[j].SetActive(false);
        //        break;
        //    case 4:
        //        battleCardObject.states_Parent.GetComponent<RectTransform>().sizeDelta = new Vector2(600, 120);
        //        for (int j = 4; j < battleCardObject.states_Image.Count; j++)
        //            battleCardObject.states_Image[j].SetActive(false);
        //        break;
        //    case 5:
        //        battleCardObject.states_Parent.GetComponent<RectTransform>().sizeDelta = new Vector2(760, 120);
        //        for (int j = 5; j < battleCardObject.states_Image.Count; j++)
        //            battleCardObject.states_Image[j].SetActive(false);
        //        break;
        //    case 6:
        //        battleCardObject.states_Parent.GetComponent<RectTransform>().sizeDelta = new Vector2(920, 120);
        //        for (int j = 6; j < battleCardObject.states_Image.Count; j++)
        //            battleCardObject.states_Image[j].SetActive(false);
        //        break;

        //    default:
        //        break;
        //}

        //for (int j = 0; j < battleCard.effectState.Count; j++)
        //{
        //    switch (battleCard.effectState[j])
        //    {
        //        case State.None:
        //            battleCardObject.states_Image[j].GetComponent<Image>().sprite = null;
        //            break;
        //        case State.Immediately:
        //            battleCardObject.states_Image[j].GetComponent<Image>().sprite = State_Immediately_Image;
        //            break;
        //        case State.AfterTheWar:
        //            battleCardObject.states_Image[j].GetComponent<Image>().sprite = State_AfterWar_Image;
        //            break;
        //        case State.ifWin:
        //            battleCardObject.states_Image[j].GetComponent<Image>().sprite = State_IfWin_Image;
        //            break;
        //        case State.ifLose:
        //            battleCardObject.states_Image[j].GetComponent<Image>().sprite = State_IfLoose_Image;
        //            break;
        //        case State.ifBattleAdvantage:
        //            battleCardObject.states_Image[j].GetComponent<Image>().sprite = State_IfBattleAdvantage_Image;
        //            break;
        //        case State.ifNotBattleAdvantage:
        //            battleCardObject.states_Image[j].GetComponent<Image>().sprite = State_IfNotBattleAdvantage_Image;
        //            break;

        //        default:
        //            break;
        //    }
        //}
        #endregion

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
        battleCardObject.tier_Image.gameObject.SetActive(true);
        switch (battleCard.tier)
        {
            case Tier.None:
                battleCardObject.tier_Image.gameObject.SetActive(false);
                battleCardObject.tier_Image.sprite = null;
                break;

            case Tier.Trash:
                battleCardObject.tier_Image.sprite = Tier_Trash_Image;
                break;
            case Tier.Common:
                battleCardObject.tier_Image.sprite = Tier_Common_Image;
                break;
            case Tier.Rare:
                battleCardObject.tier_Image.sprite = Tier_Rare_Image;
                break;
            case Tier.Epic:
                battleCardObject.tier_Image.sprite = Tier_Epic_Image;
                break;
            case Tier.Legendary:
                battleCardObject.tier_Image.sprite = Tier_Legendary_Image;
                break;

            default:
                break;
        }

        //Chakra Natures
        #region
        battleCardObject.chakraNature_Fire.SetActive(false);
        battleCardObject.chakraNature_Wind.SetActive(false);
        battleCardObject.chakraNature_Lightning.SetActive(false);
        battleCardObject.chakraNature_Water.SetActive(false);
        battleCardObject.chakraNature_Earth.SetActive(false);

        if (battleCard.fire)
            battleCardObject.chakraNature_Fire.SetActive(true);
        if (battleCard.wind)
            battleCardObject.chakraNature_Wind.SetActive(true);
        if (battleCard.lightning)
            battleCardObject.chakraNature_Lightning.SetActive(true);
        if (battleCard.water)
            battleCardObject.chakraNature_Water.SetActive(true);
        if (battleCard.earth)
            battleCardObject.chakraNature_Earth.SetActive(true);
        #endregion

        //Resources
        #region
        //Set all ResourceImages false
        for (int j = 0; j < battleCardObject.resources_Image.Count; j++)
        {
            battleCardObject.resources_Image[j].GetComponent<Image>().color = new Color(1, 1, 1, 1);
            battleCardObject.resources_Image[j].SetActive(false);
        }

        //Set relevant ResourceImages true
        #region
        if (battleCard.resources[0].amount >= 1 && battleCard.resources[0].resources != Resources.None)
            battleCardObject.resources_Image[0].SetActive(true);
        if (battleCard.resources[0].amount >= 2 && battleCard.resources[0].resources != Resources.None)
            battleCardObject.resources_Image[1].SetActive(true);
        if (battleCard.resources[0].amount >= 3 && battleCard.resources[0].resources != Resources.None)
            battleCardObject.resources_Image[2].SetActive(true);
        if (battleCard.resources[0].amount >= 4 && battleCard.resources[0].resources != Resources.None)
            battleCardObject.resources_Image[3].SetActive(true);

        if (battleCard.resources[1].amount >= 1 && battleCard.resources[1].resources != Resources.None)
            battleCardObject.resources_Image[4].SetActive(true);
        if (battleCard.resources[1].amount >= 2 && battleCard.resources[1].resources != Resources.None)
            battleCardObject.resources_Image[5].SetActive(true);
        if (battleCard.resources[1].amount >= 3 && battleCard.resources[1].resources != Resources.None)
            battleCardObject.resources_Image[6].SetActive(true);
        if (battleCard.resources[1].amount >= 4 && battleCard.resources[1].resources != Resources.None)
            battleCardObject.resources_Image[7].SetActive(true);

        if (battleCard.resources[2].amount >= 1 && battleCard.resources[2].resources != Resources.None)
            battleCardObject.resources_Image[8].SetActive(true);
        if (battleCard.resources[2].amount >= 2 && battleCard.resources[2].resources != Resources.None)
            battleCardObject.resources_Image[9].SetActive(true);
        if (battleCard.resources[2].amount >= 3 && battleCard.resources[2].resources != Resources.None)
            battleCardObject.resources_Image[10].SetActive(true);
        if (battleCard.resources[2].amount >= 4 && battleCard.resources[2].resources != Resources.None)
            battleCardObject.resources_Image[11].SetActive(true);

        if (battleCard.resources[3].amount >= 1 && battleCard.resources[3].resources != Resources.None)
            battleCardObject.resources_Image[12].SetActive(true);
        if (battleCard.resources[3].amount >= 2 && battleCard.resources[3].resources != Resources.None)
            battleCardObject.resources_Image[13].SetActive(true);
        if (battleCard.resources[3].amount >= 3 && battleCard.resources[3].resources != Resources.None)
            battleCardObject.resources_Image[14].SetActive(true);
        if (battleCard.resources[3].amount >= 4 && battleCard.resources[3].resources != Resources.None)
            battleCardObject.resources_Image[15].SetActive(true);
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
                        battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Boat;

                        switch (battleCard.clan)
                        {
                            case Clan.None:
                                battleCardObject.resources_Image[k].GetComponent<Image>().sprite = null;
                                break;
                            case Clan.Akatsuki_Awakening:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetAkatsuki_BorderColor();
                                break;
                            case Clan.Akatsuki:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetAkatsuki_BorderColor();
                                break;
                            case Clan.Hyuga:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetHyuga_BorderColor();
                                break;
                            case Clan.Otsutsuki:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetOtsutsuki_BorderColor();
                                break;
                            case Clan.Senju:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetSenju_BorderColor();
                                break;
                            case Clan.Uchiha:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetUchiha_BorderColor();
                                break;
                            case Clan.Uzumaki:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetUzumaki_BorderColor();
                                break;
                            case Clan.Kara:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetKara_BorderColor();
                                break;
                            case Clan.Ally:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = new Color(0, 0, 0, 1);
                                break;
                            case Clan.Ally_Rare:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = new Color(0, 0, 0, 1);
                                break;
                            case Clan.Ally_Epic:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = new Color(0, 0, 0, 1);
                                break;
                            case Clan.Ally_Legendary:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = new Color(0, 0, 0, 1);
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
                                battleCardObject.resources_Image[k].GetComponent<Image>().sprite = null;
                                break;
                            case Clan.Akatsuki_Awakening:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetAkatsuki_BorderColor();
                                break;
                            case Clan.Akatsuki:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetAkatsuki_BorderColor();
                                break;
                            case Clan.Hyuga:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetHyuga_BorderColor();
                                break;
                            case Clan.Otsutsuki:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetOtsutsuki_BorderColor();
                                break;
                            case Clan.Senju:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetSenju_BorderColor();
                                break;
                            case Clan.Uchiha:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetUchiha_BorderColor();
                                break;
                            case Clan.Uzumaki:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetUzumaki_BorderColor();
                                break;
                            case Clan.Kara:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetKara_BorderColor();
                                break;
                            case Clan.Ally:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = new Color(0, 0, 0, 1);
                                break;
                            case Clan.Ally_Rare:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = new Color(0, 0, 0, 1);
                                break;
                            case Clan.Ally_Epic:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = new Color(0, 0, 0, 1);
                                break;
                            case Clan.Ally_Legendary:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = new Color(0, 0, 0, 1);
                                break;

                            default:
                                break;
                        }

                        battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Chuunin;
                    }
                    break;
                case Resources.Jounin:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                    {
                        switch (battleCard.clan)
                        {
                            case Clan.None:
                                battleCardObject.resources_Image[k].GetComponent<Image>().sprite = null;
                                break;
                            case Clan.Akatsuki_Awakening:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetAkatsuki_BorderColor();
                                break;
                            case Clan.Akatsuki:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetAkatsuki_BorderColor();
                                break;
                            case Clan.Hyuga:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetHyuga_BorderColor();
                                break;
                            case Clan.Otsutsuki:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetOtsutsuki_BorderColor();
                                break;
                            case Clan.Senju:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetSenju_BorderColor();
                                break;
                            case Clan.Uchiha:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetUchiha_BorderColor();
                                break;
                            case Clan.Uzumaki:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetUzumaki_BorderColor();
                                break;
                            case Clan.Kara:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetKara_BorderColor();
                                break;
                            case Clan.Ally:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = new Color(0, 0, 0, 1);
                                break;
                            case Clan.Ally_Rare:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = new Color(0, 0, 0, 1);
                                break;
                            case Clan.Ally_Epic:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = new Color(0, 0, 0, 1);
                                break;
                            case Clan.Ally_Legendary:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = new Color(0, 0, 0, 1);
                                break;

                            default:
                                break;
                        }

                        battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Jounin;
                    }
                    break;
                case Resources.Kage:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                    {
                        switch (battleCard.clan)
                        {
                            case Clan.None:
                                battleCardObject.resources_Image[k].GetComponent<Image>().sprite = null;
                                break;
                            case Clan.Akatsuki_Awakening:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetAkatsuki_BorderColor();
                                break;
                            case Clan.Akatsuki:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetAkatsuki_BorderColor();
                                break;
                            case Clan.Hyuga:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetHyuga_BorderColor();
                                break;
                            case Clan.Otsutsuki:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetOtsutsuki_BorderColor();
                                break;
                            case Clan.Senju:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetSenju_BorderColor();
                                break;
                            case Clan.Uchiha:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetUchiha_BorderColor();
                                break;
                            case Clan.Uzumaki:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetUzumaki_BorderColor();
                                break;
                            case Clan.Kara:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = colorManager.GetKara_BorderColor();
                                break;
                            case Clan.Ally:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = new Color(0, 0, 0, 1);
                                break;
                            case Clan.Ally_Rare:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = new Color(0, 0, 0, 1);
                                break;
                            case Clan.Ally_Epic:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = new Color(0, 0, 0, 1);
                                break;
                            case Clan.Ally_Legendary:
                                battleCardObject.resources_Image[k].GetComponent<Image>().color = new Color(0, 0, 0, 1);
                                break;

                            default:
                                break;
                        }

                        battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Kage;
                    }
                    break;
                case Resources.ActionCard:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                        battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_ActionCard;
                    break;
                case Resources.ClanCard:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                    {
                        switch (battleCard.clan)
                        {
                            case Clan.None:
                                battleCardObject.resources_Image[k].GetComponent<Image>().sprite = null;
                                break;
                            case Clan.Akatsuki_Awakening:
                                battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_ClanCard_Akatsuki;
                                break;
                            case Clan.Akatsuki:
                                battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_ClanCard_Akatsuki;
                                break;
                            case Clan.Hyuga:
                                battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_ClanCard_Hyuga;
                                break;
                            case Clan.Otsutsuki:
                                battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_ClanCard_Otsutsuki;
                                break;
                            case Clan.Senju:
                                battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_ClanCard_Senju;
                                break;
                            case Clan.Uchiha:
                                battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_ClanCard_Uchiha;
                                break;
                            case Clan.Uzumaki:
                                battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_ClanCard_Uzumaki;
                                break;
                            case Clan.Kara:
                                battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_ClanCard_Kara;
                                break;
                            case Clan.Ally:
                                battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_ClanCard_Ally;
                                break;
                            case Clan.Ally_Rare:
                                battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_ClanCard_Ally;
                                break;
                            case Clan.Ally_Epic:
                                battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_ClanCard_Ally;
                                break;
                            case Clan.Ally_Legendary:
                                battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_ClanCard_Ally;
                                break;

                            default:
                                break;
                        }
                    }
                    break;
                case Resources.Ally_Rare:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                        battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Ally_Rare;
                    break;
                case Resources.Ally_Epic:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                        battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Ally_Epic;
                    break;
                case Resources.Ally_Legendary:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                        battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Ally_Legendary;
                    break;
                case Resources.Effect_Poison:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                        battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Effect_Poison;
                    break;
                case Resources.Effect_Paralyze:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                        battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Effect_Paralyze;
                    break;
                case Resources.Effect_Illusion:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                        battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Effect_Illusion;
                    break;
                case Resources.Effect_Freeze:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                        battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Effect_Freeze;
                    break;
                case Resources.Effect_Chain:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                        battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Effect_Chain;
                    break;
                case Resources.Effect_Substitution:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                        battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Effect_Substitution;
                    break;
                case Resources.Influence_UP:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                        battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Effect_Influence_UP;
                    break;
                case Resources.Influence_DOWN:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                        battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Effect_Influence_DOWN;
                    break;
                case Resources.Coin:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                        battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Effect_Coin;
                    break;
                case Resources.TailedBeast:
                    for (int k = (4 * j); k < (4 * j) + 4; k++)
                        battleCardObject.resources_Image[k].GetComponent<Image>().sprite = Resource_Effect_TailedBeast;
                    break;

                default:
                    break;
            }
        }
        #endregion

        //Card info
        #region
        switch (battleCard.set)
        {
            case setNames.None:
                battleCardObject.setImage.sprite = null;
                break;
            case setNames.Base:
                battleCardObject.setImage.sprite = CardDisplayManager.Instance.baseSet_Icon;
                break;

            default:
                break;
        }

        if (battleCard.index < 10)
            battleCardObject.infoText.text = "no. 000" + battleCard.index + " - " + CardDisplayManager.Instance.companyName + " © " + "2016 - " + CardDisplayManager.Instance.endYear;
        else if (battleCard.index < 100)
            battleCardObject.infoText.text = "no. 00" + battleCard.index + " - " + CardDisplayManager.Instance.companyName + " © " + "2016 - " + CardDisplayManager.Instance.endYear;
        else if (battleCard.index < 1000)
            battleCardObject.infoText.text = "no. 0" + battleCard.index + " - " + CardDisplayManager.Instance.companyName + " © " + "2016 - " + CardDisplayManager.Instance.endYear;
        else
            battleCardObject.infoText.text = "no. " + battleCard.index + " - " + CardDisplayManager.Instance.companyName + " © " + "2016 - " + CardDisplayManager.Instance.endYear;
        #endregion
    }

    void DisplayTextOnly(BattleCard battleCard)
    {
        battleCardObject.effectText_Parent.SetActive(true);
        battleCardObject.effectTextIcon_Parent.SetActive(false);
        battleCardObject.effectIcon_Parent.SetActive(false);

        battleCardObject.effectText_Parent.GetComponentInChildren<TextMeshProUGUI>().text = battleCard.effectText;

        //TextSize
        //if (battleCard.textSize > 0)
        //{
        //    //battleCardDescriptionText.autoSizeTextContainer = false;
        //    battleCardDescriptionText.fontSize = battleCard.textSize;
        //    battleCardDescriptionText.GetComponent<RectTransform>().sizeDelta = new Vector2(1410, 520);
        //}
        //else
        //{
        //    //battleCardDescriptionText.autoSizeTextContainer = true;
        //    battleCardDescriptionText.GetComponent<RectTransform>().sizeDelta = new Vector2(1410, 520);
        //}

        battleCardDescriptionText.GetComponent<RectTransform>().sizeDelta = new Vector2(1410, 520);
    }
    void Display3Icons(BattleCard battleCard)
    {
        battleCardObject.effectText_Parent.SetActive(false);
        battleCardObject.effectTextIcon_Parent.SetActive(false);
        battleCardObject.effectIcon_Parent.SetActive(true);

        battleCardObject.effectIcons[0].SetActive(false);
        battleCardObject.effectIcons[1].SetActive(false);
        battleCardObject.effectIcons[2].SetActive(false);

        //Make correct size
        battleCardObject.effectIcon_Parent.GetComponent<RectTransform>().sizeDelta = new Vector2(1400, 453.3f);

        //Show correct image
        for (int j = 0; j < 3; j++)
        {
            if (battleCard.effectIcon[j] == EffectIcon.Skull)
            {
                battleCardObject.effectIcons[j].SetActive(true);
                battleCardObject.effectIcons[j].GetComponentInChildren<Image>().sprite = Skull;
            }
            else if (battleCard.effectIcon[j] == EffectIcon.Shield)
            {
                battleCardObject.effectIcons[j].SetActive(true);
                battleCardObject.effectIcons[j].GetComponentInChildren<Image>().sprite = Shield;
            }
        }
    }
    void Display2Icons(BattleCard battleCard, int k, int l)
    {
        battleCardObject.effectText_Parent.SetActive(false);
        battleCardObject.effectTextIcon_Parent.SetActive(false);
        battleCardObject.effectIcon_Parent.SetActive(true);

        battleCardObject.effectIcons[0].SetActive(false);
        battleCardObject.effectIcons[1].SetActive(false);
        battleCardObject.effectIcons[2].SetActive(false);

        //Make correct size
        battleCardObject.effectIcon_Parent.GetComponent<RectTransform>().sizeDelta = new Vector2(926.6f, 453.3f);

        //Show correct image
        //k
        if (battleCard.effectIcon[k] == EffectIcon.Skull)
        {
            battleCardObject.effectIcons[k].SetActive(true);
            battleCardObject.effectIcons[k].GetComponentInChildren<Image>().sprite = Skull;
        }
        else if (battleCard.effectIcon[k] == EffectIcon.Shield)
        {
            battleCardObject.effectIcons[k].SetActive(true);
            battleCardObject.effectIcons[k].GetComponentInChildren<Image>().sprite = Shield;
        }

        //l
        if (battleCard.effectIcon[l] == EffectIcon.Skull)
        {
            battleCardObject.effectIcons[l].SetActive(true);
            battleCardObject.effectIcons[l].GetComponentInChildren<Image>().sprite = Skull;
        }
        else if (battleCard.effectIcon[l] == EffectIcon.Shield)
        {
            battleCardObject.effectIcons[l].SetActive(true);
            battleCardObject.effectIcons[l].GetComponentInChildren<Image>().sprite = Shield;
        }
    }
    void Display1Icon(BattleCard battleCard)
    {
        battleCardObject.effectIcons[0].SetActive(true);
        battleCardObject.effectIcons[1].SetActive(false);
        battleCardObject.effectIcons[2].SetActive(false);

        battleCardObject.effectText_Parent.SetActive(false);
        battleCardObject.effectTextIcon_Parent.SetActive(false);
        battleCardObject.effectIcon_Parent.SetActive(true);

        battleCardObject.effectIcon_Parent.GetComponent<RectTransform>().sizeDelta = new Vector2(453.3f, 453.3f);

        if (battleCard.effectIcon[0] == EffectIcon.Skull)
        {
            battleCardObject.effectIcons[0].GetComponentInChildren<Image>().sprite = Skull;
        }
        else if (battleCard.effectIcon[0] == EffectIcon.Shield)
        {
            battleCardObject.effectIcons[0].GetComponentInChildren<Image>().sprite = Shield;
        }
    }
    void DisplayTextAndIcon(BattleCard battleCard, int k)
    {
        battleCardObject.effectText_Parent.SetActive(false);
        battleCardObject.effectTextIcon_Parent.SetActive(true);
        battleCardObject.effectIcon_Parent.SetActive(false);

        battleCardObject.effectTextIcon_Parent.GetComponentInChildren<TextMeshProUGUI>().text = battleCard.effectText;

        if (battleCard.effectIcon[k] == EffectIcon.Skull)
        {
            battleCardObject.effectTextIcon_Parent.GetComponentInChildren<Image>().sprite = Skull;
        }
        else if (battleCard.effectIcon[k] == EffectIcon.Shield)
        {
            battleCardObject.effectTextIcon_Parent.GetComponentInChildren<Image>().sprite = Shield;
        }

        //TextSize
        //if (battleCard.textSize > 0)
        //{
        //    //battleCardIconTextDescriptionText.autoSizeTextContainer = false;
        //    battleCardIconTextDescriptionText.fontSize = battleCard.textSize;
        //    battleCardIconTextDescriptionText.GetComponent<RectTransform>().sizeDelta = new Vector2(885, 520);
        //}
        //else
        //{
        //    //battleCardIconTextDescriptionText.autoSizeTextContainer = true;
        //    battleCardIconTextDescriptionText.GetComponent<RectTransform>().sizeDelta = new Vector2(885, 520);
        //}

        battleCardIconTextDescriptionText.GetComponent<RectTransform>().sizeDelta = new Vector2(885, 520);
    }


    //--------------------


    public void DisplayEventCard(EventCard eventCard)
    {
        eventCardObject.header.text = eventCard.name;
        eventCardObject.description.text = eventCard.description;
        eventCardObject.image.sprite = eventCard.image;

        //First Round Image
        eventCardObject.isBothImage.SetActive(false);
        eventCardObject.isFirstRoundImage.SetActive(false);
        eventCardObject.isLastRoundImage.SetActive(false);

        if (eventCard.isFirstRound && eventCard.isLastRound)
        {
            eventCardObject.isBothImage.SetActive(true);
        }
        else if (eventCard.isFirstRound)
        {
            eventCardObject.isFirstRoundImage.SetActive(true);
        }
        else if (eventCard.isLastRound)
        {
            eventCardObject.isLastRoundImage.SetActive(true);
        }
    }

    public void DisplayActionCard(ActionCard actioncard)
    {
        actionCardObject.name.text = actioncard.name;
        actionCardObject.description.text = actioncard.description;

        //Image
        actionCardObject.icon.sprite = actioncard.image;

        //Type
        switch (actioncard.type)
        {
            case ActionCardTypes.None:
                actionCardObject.type.text = "-";
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
        //Set all Coin Images = false
        for (int j = 0; j < actionCardObject.coin.Count; j++)
        {
            actionCardObject.coin[j].SetActive(false);
        }
        for (int j = 0; j < actionCardObject.hiddenDeckIcon.Count; j++)
        {
            actionCardObject.hiddenDeckIcon[j].SetActive(false);
        }

        //Make relevant coin Images visible
        if (!actioncard.isInHiddenDeck)
        {
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
        }
        else
        {
            switch (actioncard.cost)
            {
                case 1:
                    actionCardObject.hiddenDeckIcon[0].SetActive(true);
                    break;
                case 2:
                    actionCardObject.hiddenDeckIcon[0].SetActive(true);
                    actionCardObject.hiddenDeckIcon[1].SetActive(true);
                    break;
                case 3:
                    actionCardObject.hiddenDeckIcon[0].SetActive(true);
                    actionCardObject.hiddenDeckIcon[1].SetActive(true);
                    actionCardObject.hiddenDeckIcon[2].SetActive(true);
                    break;
                case 4:
                    actionCardObject.hiddenDeckIcon[0].SetActive(true);
                    actionCardObject.hiddenDeckIcon[1].SetActive(true);
                    actionCardObject.hiddenDeckIcon[2].SetActive(true);
                    actionCardObject.hiddenDeckIcon[3].SetActive(true);
                    break;
                case 5:
                    actionCardObject.hiddenDeckIcon[0].SetActive(true);
                    actionCardObject.hiddenDeckIcon[1].SetActive(true);
                    actionCardObject.hiddenDeckIcon[2].SetActive(true);
                    actionCardObject.hiddenDeckIcon[3].SetActive(true);
                    actionCardObject.hiddenDeckIcon[4].SetActive(true);
                    break;
                case 6:
                    actionCardObject.hiddenDeckIcon[0].SetActive(true);
                    actionCardObject.hiddenDeckIcon[1].SetActive(true);
                    actionCardObject.hiddenDeckIcon[2].SetActive(true);
                    actionCardObject.hiddenDeckIcon[3].SetActive(true);
                    actionCardObject.hiddenDeckIcon[4].SetActive(true);
                    actionCardObject.hiddenDeckIcon[5].SetActive(true);
                    break;
                default:
                    break;
            }
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

        //TextSize
        if (actioncard.textSize > 0)
        {
            //actionCardDescriptionText.autoSizeTextContainer = false;
            actionCardDescriptionText.fontSize = actioncard.textSize;
            actionCardDescriptionText.GetComponent<RectTransform>().sizeDelta = new Vector2(1430, 400);
        }
        else
        {
            //actionCardDescriptionText.autoSizeTextContainer = true;
            actionCardDescriptionText.GetComponent<RectTransform>().sizeDelta = new Vector2(1430, 400);
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
            case Clan.Kara:
                clanSpecialtyCardObject.backgorund.color = new Color(0.25f, 0.73f, 1, 1);
                clanSpecialtyCardObject.backgorund_over.color = new Color(0.25f, 0.73f, 1, 1);
                clanSpecialtyCardObject.frame.color = colorManager.GetKara_BorderColor();
                clanSpecialtyCardObject.header.color = new Color(0f, 0.35f, 0.42f, 1f);
                clanSpecialtyCardObject.description.color = new Color(0f, 0.35f, 0.42f, 1f);
                clanSpecialtyCardObject.clanSymbol.sprite = Icon_Kara;
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

        //TextSize
        if (clanSpecialtyCard.textSize > 0)
        {
            //clanSpecialtyDescriptionText.autoSizeTextContainer = false;
            clanSpecialtyDescriptionText.fontSize = clanSpecialtyCard.textSize;
            clanSpecialtyDescriptionText.GetComponent<RectTransform>().sizeDelta = new Vector2(1400, 940);
        }
        else
        {
            //clanSpecialtyDescriptionText.autoSizeTextContainer = true;
            clanSpecialtyDescriptionText.GetComponent<RectTransform>().sizeDelta = new Vector2(1400, 940);
        }
    }
}

