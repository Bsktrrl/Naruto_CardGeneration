using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
    #region Variables
    [SerializeField] SO_NarutoCard so_NarutoCard;
    [SerializeField] CardObject cardObject;
    [SerializeField] ColorManager colorManager;

    [Header("Heal Images")]
    public Sprite Heal_Image;
    public Sprite HealBlock_Image;

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

    [Header("Resources Images")]
    public Sprite Resources_ClanCard;

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
    #endregion


    //--------------------


    private void Start()
    {
        DisplayCard(0);
    }


    //--------------------


    public void DisplayCard(int i)
    {
        //Colors depending on Card Type
        switch (so_NarutoCard.cardList[i].clan)
        {
            case Clan.None:
                for (int j = 0; j < cardObject.background_Image.Count; j++)
                {
                    cardObject.background_Image[j] = null;
                }
                cardObject.Frame_Image = null;
                for (int j = 0; j < cardObject.landOrigins_Image.Count; j++)
                {
                    cardObject.landOrigins_Image[j] = null;
                }

                cardObject.name_Text = null;
                cardObject.loreInfo_Text = null;

                cardObject.taijutsuValue_Text = null;
                cardObject.ninjutsuValue_Text = null;
                cardObject.genjutsuValue_Text = null;

                for (int j = 0; j < cardObject.states_Image.Count; j++)
                {
                    cardObject.states_Image[j] = null;
                }
                cardObject.effect_Text = null;
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

                for (int j = 0; j < cardObject.states_Image.Count; j++)
                {
                    cardObject.states_Image[j].GetComponentInChildren<Image>().color = colorManager.GetAkatsuki_TextColor();
                }
                cardObject.effect_Text.color = colorManager.GetAkatsuki_TextColor();
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

                for (int j = 0; j < cardObject.states_Image.Count; j++)
                {
                    cardObject.states_Image[j].GetComponentInChildren<Image>().color = colorManager.GetHyuga_TextColor();
                }
                cardObject.effect_Text.color = colorManager.GetHyuga_TextColor();
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

                for (int j = 0; j < cardObject.states_Image.Count; j++)
                {
                    cardObject.states_Image[j].GetComponentInChildren<Image>().color = colorManager.GetOtsutsuki_TextColor();
                }
                cardObject.effect_Text.color = colorManager.GetOtsutsuki_TextColor();
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

                for (int j = 0; j < cardObject.states_Image.Count; j++)
                {
                    cardObject.states_Image[j].GetComponentInChildren<Image>().color = colorManager.GetSenju_TextColor();
                }
                cardObject.effect_Text.color = colorManager.GetSenju_TextColor();
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

                for (int j = 0; j < cardObject.states_Image.Count; j++)
                {
                    cardObject.states_Image[j].GetComponentInChildren<Image>().color = colorManager.GetUchiha_TextColor();
                }
                cardObject.effect_Text.color = colorManager.GetUchiha_TextColor();
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

                for (int j = 0; j < cardObject.states_Image.Count; j++)
                {
                    cardObject.states_Image[j].GetComponentInChildren<Image>().color = colorManager.GetUzumaki_TextColor();
                }
                cardObject.effect_Text.color = colorManager.GetUzumaki_TextColor();
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

                for (int j = 0; j < cardObject.states_Image.Count; j++)
                {
                    cardObject.states_Image[j].GetComponentInChildren<Image>().color = colorManager.GetAlly_TextColor();
                }
                cardObject.effect_Text.color = colorManager.GetAlly_TextColor();
                break;

            default:
                break;
        }

        //Name Box
        cardObject.name_Text.text = so_NarutoCard.cardList[i].name;
        cardObject.loreInfo_Text.text = so_NarutoCard.cardList[i].loreInfo;
        for (int j = 0; j < cardObject.landOrigins_Image.Count; j++)
        {
            switch (so_NarutoCard.cardList[i].landOrigins)
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
        cardObject.characterImage.sprite = so_NarutoCard.cardList[i].characterSprite;

        //Values
        cardObject.taijutsuValue_Text.text = so_NarutoCard.cardList[i].TaijutsuValue.ToString();
        cardObject.ninjutsuValue_Text.text = so_NarutoCard.cardList[i].NinjutsuValue.ToString();
        cardObject.genjutsuValue_Text.text = so_NarutoCard.cardList[i].GenjutsuValue.ToString();

        //Heal
        switch (so_NarutoCard.cardList[i].heal)
        {
            case Heal.None:
                cardObject.healParent.SetActive(false);
                cardObject.heal_Image = null;
                break;
            case Heal.Heal:
                cardObject.healParent.SetActive(true);
                cardObject.heal_Image.sprite = Heal_Image;
                break;
            case Heal.HealBlock:
                cardObject.healParent.SetActive(true);
                cardObject.heal_Image.sprite = HealBlock_Image;
                break;

            default:
                break;
        }

        //Tailed Beast Heads
        switch (so_NarutoCard.cardList[i].headAmount)
        {
            case 0:
                cardObject.headParent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 30);
                cardObject.heads_Image[0].SetActive(false);
                cardObject.heads_Image[1].SetActive(false);
                cardObject.heads_Image[2].SetActive(false);
                cardObject.heads_Image[3].SetActive(false);
                cardObject.heads_Image[4].SetActive(false);
                break;
            case 1:
                cardObject.headParent.GetComponent<RectTransform>().sizeDelta = new Vector2(30, 30);
                cardObject.heads_Image[0].SetActive(true);
                cardObject.heads_Image[1].SetActive(false);
                cardObject.heads_Image[2].SetActive(false);
                cardObject.heads_Image[3].SetActive(false);
                cardObject.heads_Image[4].SetActive(false);
                break;
            case 2:
                cardObject.headParent.GetComponent<RectTransform>().sizeDelta = new Vector2(70, 30);
                cardObject.heads_Image[0].SetActive(true);
                cardObject.heads_Image[1].SetActive(true);
                cardObject.heads_Image[2].SetActive(false);
                cardObject.heads_Image[3].SetActive(false);
                cardObject.heads_Image[4].SetActive(false);
                break;
            case 3:
                cardObject.headParent.GetComponent<RectTransform>().sizeDelta = new Vector2(110, 30);
                cardObject.heads_Image[0].SetActive(true);
                cardObject.heads_Image[1].SetActive(true);
                cardObject.heads_Image[2].SetActive(true);
                cardObject.heads_Image[3].SetActive(false);
                cardObject.heads_Image[4].SetActive(false);
                break;
            case 4:
                cardObject.headParent.GetComponent<RectTransform>().sizeDelta = new Vector2(150, 30);
                cardObject.heads_Image[0].SetActive(true);
                cardObject.heads_Image[1].SetActive(true);
                cardObject.heads_Image[2].SetActive(true);
                cardObject.heads_Image[3].SetActive(true);
                cardObject.heads_Image[4].SetActive(false);
                break;
            case 5:
                cardObject.headParent.GetComponent<RectTransform>().sizeDelta = new Vector2(190, 30);
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


        //  - Text
        cardObject.effect_Text.text = so_NarutoCard.cardList[i].effectText;

        //  - Tier
        switch (so_NarutoCard.cardList[i].tier)
        {
            case Tier.None:
                cardObject.tier_Image = null;
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


    }
}
