using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    CardManager cardManager;

    [Header("UI Parents")]
    [SerializeField] GameObject battleUI_Parent;
    [SerializeField] GameObject actionUI_Parent;
    [SerializeField] GameObject clanSpecialtyUI_Parent;

    [Header("Card Lists")]
    List<SO_NarutoCard> battleCards = new List<SO_NarutoCard>();
    List<SO_ActionCard> actionCards = new List<SO_ActionCard>();
    List<SO_ClanSpecialtyCard> clanSpecialtyCards = new List<SO_ClanSpecialtyCard>();

    [Header("Bool Checks")]
    public bool isTakingScreenShots = false;


    //--------------------


    private void Start()
    {
        cardManager = FindObjectOfType<CardManager>();

        //Add BattleCards to list
        battleCards.Add(cardManager.battle_Akatsuki);
        battleCards.Add(cardManager.battle_Hyuga);
        battleCards.Add(cardManager.battle_Otsutsuki);
        battleCards.Add(cardManager.battle_Senju);
        battleCards.Add(cardManager.battle_Uchiha);
        battleCards.Add(cardManager.battle_Uzumaki);
        battleCards.Add(cardManager.battle_Ally_Rare);
        battleCards.Add(cardManager.battle_Ally_Epic);
        battleCards.Add(cardManager.battle_Ally_Legendary);

        //Add ActionCards to List
        actionCards.Add(cardManager.actionCards);

        //Add ClanSpecialty to List
        clanSpecialtyCards.Add(cardManager.clanSpecialty_Akatsuki);
        clanSpecialtyCards.Add(cardManager.clanSpecialty_Hyuga);
        clanSpecialtyCards.Add(cardManager.clanSpecialty_Otsutsuki);
        clanSpecialtyCards.Add(cardManager.clanSpecialty_Senju);
        clanSpecialtyCards.Add(cardManager.clanSpecialty_Uchiha);
        clanSpecialtyCards.Add(cardManager.clanSpecialty_Uzumaki);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            isTakingScreenShots = true;

            Screenhot();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            ScreenCapture.CaptureScreenshot("Test.png", 1);
            print("Screen captured - Finished");
        }
    }

    void Screenhot()
    {
        StartCoroutine(AllCards());
    }

    IEnumerator AllCards()
    {
        //Set Parents = false
        battleUI_Parent.SetActive(false);
        actionUI_Parent.SetActive(false);
        clanSpecialtyUI_Parent.SetActive(false);

        //Battle Cards
        for (int i = 0; i < battleCards.Count; i++)
        {
            battleUI_Parent.SetActive(true);
            actionUI_Parent.SetActive(false);
            clanSpecialtyUI_Parent.SetActive(false);

            //Each Iteration for each card in the List
            for (int j = 0; j < battleCards[i].cardList.Count; j++)
            {
                cardManager.DisplayBattleCard(battleCards[i].cardList[j]);

                yield return new WaitForSeconds(0.2f);

                ScreenCapture.CaptureScreenshot(battleCards[i].cardList[j].cardType + "_" + battleCards[i].cardList[j].clan + "_" + battleCards[i].cardList[j].name + "_" + battleCards[i].cardList[j].loreInfo + ".png", 1);
                print("Screen captured - Battle Card: " + i + " " + j);

                yield return new WaitForSeconds(0.8f);
            }
        }

        //Action Cards
        for (int i = 0; i < actionCards.Count; i++)
        {
            battleUI_Parent.SetActive(false);
            actionUI_Parent.SetActive(true);
            clanSpecialtyUI_Parent.SetActive(false);

            //Each Iteration for each card in the List
            for (int j = 0; j < actionCards[i].actionCardList.Count; j++)
            {
                cardManager.DisplayActionCard(actionCards[i].actionCardList[j]);

                yield return new WaitForSeconds(0.2f);

                ScreenCapture.CaptureScreenshot(actionCards[i].actionCardList[j].cardType + "_" + actionCards[i].actionCardList[j].name + ".png", 1);
                print("Screen captured - Action Card: " + i + " " + j);

                yield return new WaitForSeconds(0.8f);
            }
        }

        //Clan Specialty Cards
        for (int i = 0; i < clanSpecialtyCards.Count; i++)
        {
            battleUI_Parent.SetActive(false);
            actionUI_Parent.SetActive(false);
            clanSpecialtyUI_Parent.SetActive(true);

            //Each Iteration for each card in the List
            for (int j = 0; j < clanSpecialtyCards[i].clanSpecialtyCardList.Count; j++)
            {
                cardManager.DisplayClanSpecialty(clanSpecialtyCards[i].clanSpecialtyCardList[j]);

                yield return new WaitForSeconds(0.2f);

                ScreenCapture.CaptureScreenshot(clanSpecialtyCards[i].clanSpecialtyCardList[j].cardType + "_" + clanSpecialtyCards[i].clanSpecialtyCardList[j].clan + "_" + clanSpecialtyCards[i].clanSpecialtyCardList[j].name + ".png", 1);
                print("Screen captured - Action Card: " + i + " " + j);

                yield return new WaitForSeconds(0.8f);
            }
        }

        isTakingScreenShots = false;
    }
}
