using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : Singleton<MainManager>
{
    CardManager cardManager;
    [SerializeField] BattleCardObject battleCardObject;
    [SerializeField] ActionCardObject actionCardObject;
    [SerializeField] ClanSpecialtyCardObject clanSpecialtyCardObject;
    [SerializeField] EventCardObject eventCardObject;

    [Header("UI Parents")]
    public GameObject battleUI_Parent;
    public GameObject actionUI_Parent;
    public GameObject clanSpecialtyUI_Parent;
    public GameObject eventUI_Parent;

    [Header("Card Lists")]
    List<SO_NarutoCard> battleCards = new List<SO_NarutoCard>();
    List<SO_ActionCard> actionCards = new List<SO_ActionCard>();
    List<SO_ClanSpecialtyCard> clanSpecialtyCards = new List<SO_ClanSpecialtyCard>();
    List<SO_Event> eventCards = new List<SO_Event>();

    [Header("Bool Checks")]
    public bool isTakingScreenShots = false;


    //--------------------


    private void Start()
    {
        cardManager = FindObjectOfType<CardManager>();

        //Add BattleCards to list
        battleCards.Add(cardManager.battle_Akatsuki_Awakening);
        battleCards.Add(cardManager.battle_Akatsuki);
        battleCards.Add(cardManager.battle_Hyuga);
        battleCards.Add(cardManager.battle_Otsutsuki);
        battleCards.Add(cardManager.battle_Senju);
        battleCards.Add(cardManager.battle_Uchiha);
        battleCards.Add(cardManager.battle_Uzumaki);
        battleCards.Add(cardManager.battle_Kara);
        battleCards.Add(cardManager.battle_Ally_Rare);
        battleCards.Add(cardManager.battle_Ally_Epic);
        battleCards.Add(cardManager.battle_Ally_Legendary);

        //Add ActionCards to List
        actionCards.Add(cardManager.actionCards);

        //Add ClanSpecialty to List
        clanSpecialtyCards.Add(cardManager.clanSpecialty_Akatsuki);
        clanSpecialtyCards.Add(cardManager.clanSpecialty_Hyuga);
        clanSpecialtyCards.Add(cardManager.clanSpecialty_Otsutsuki);
        clanSpecialtyCards.Add(cardManager.clanSpecialty_Kara);
        clanSpecialtyCards.Add(cardManager.clanSpecialty_Senju);
        clanSpecialtyCards.Add(cardManager.clanSpecialty_Uchiha);
        clanSpecialtyCards.Add(cardManager.clanSpecialty_Uzumaki);

        //Add EventCards to List
        eventCards.Add(cardManager.eventCards);
    }
    private void Update()
    {
        //Print all Cards in the Database
        if (Input.GetKeyDown(KeyCode.A))
        {
            isTakingScreenShots = true;

            StartCoroutine(ScreenShot_AllCards());
        }

        //Print current Card displayed
        else if (Input.GetKeyDown(KeyCode.S))
        {
            if (battleUI_Parent.activeInHierarchy)
            {
                for (int i = 0; i < battleCards.Count; i++)
                {
                    for (int j = 0; j < battleCards[i].cardList.Count; j++)
                    {
                        if (battleCardObject.name_Text.text == battleCards[i].cardList[j].name
                            && battleCardObject.loreInfo_Text.text == "- " + battleCards[i].cardList[j].loreInfo + " -")
                        {
                            PrintBattleCard(i, j);
                            break;
                        }
                    }
                }
            }
            else if (actionUI_Parent.activeInHierarchy)
            {
                for (int i = 0; i < actionCards.Count; i++)
                {
                    for (int j = 0; j < actionCards[i].actionCardList.Count; j++)
                    {
                        if (actionCardObject.name.text == actionCards[i].actionCardList[j].name)
                        {
                            PrintActionCard(i, j);
                            break;
                        }
                    }
                }
            }
            else if (clanSpecialtyUI_Parent.activeInHierarchy)
            {
                for (int i = 0; i < clanSpecialtyCards.Count; i++)
                {
                    for (int j = 0; j < clanSpecialtyCards[i].clanSpecialtyCardList.Count; j++)
                    {
                        if (clanSpecialtyCardObject.header.text == clanSpecialtyCards[i].clanSpecialtyCardList[j].name)
                        {
                            PrintClanSpecialtyCard(i, j);
                            break;
                        }
                    }
                }
            }
            else if (eventUI_Parent.activeInHierarchy)
            {
                for (int i = 0; i < eventCards.Count; i++)
                {
                    for (int j = 0; j < eventCards[i].eventCardList.Count; j++)
                    {
                        if (eventCardObject.header.text == eventCards[i].eventCardList[j].name)
                        {
                            PrintEventCard(i, j);
                            break;
                        }
                    }
                }
            }
        }

        //Print all cards of the active card type
        else if (Input.GetKeyDown(KeyCode.D))
        {
            isTakingScreenShots = true;

            if (battleUI_Parent.activeInHierarchy)
            {
                //Battle Cards
                StartCoroutine(ScreenShot_AllBattleCards());
            }
            else if (actionUI_Parent.activeInHierarchy)
            {
                //Action Cards
                StartCoroutine(ScreenShot_AllActionCards());
            }
            else if (clanSpecialtyUI_Parent.activeInHierarchy)
            {
                //Clan Specialty Cards
                StartCoroutine(ScreenShot_AllClanSpecialtyCards());
            }
            else if (eventUI_Parent.activeInHierarchy)
            {
                //Event Cards
                StartCoroutine(ScreenShot_AllEventCards());
            }
        }
    }


    //--------------------


    IEnumerator ScreenShot_AllCards()
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

                yield return new WaitForSeconds(0.01f);

                PrintBattleCard(i, j);

                yield return new WaitForSeconds(0.01f);
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

                yield return new WaitForSeconds(0.01f);

                PrintActionCard(i, j);

                yield return new WaitForSeconds(0.01f);
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

                yield return new WaitForSeconds(0.01f);

                PrintClanSpecialtyCard(i, j);

                yield return new WaitForSeconds(0.01f);
            }
        }

        isTakingScreenShots = false;
    }

    IEnumerator ScreenShot_AllBattleCards()
    {
        for (int i = 0; i < battleCards.Count; i++)
        {
            battleUI_Parent.SetActive(true);
            actionUI_Parent.SetActive(false);
            clanSpecialtyUI_Parent.SetActive(false);
            eventUI_Parent.SetActive(false);

            //Each Iteration for each card in the List
            for (int j = 0; j < battleCards[i].cardList.Count; j++)
            {
                cardManager.DisplayBattleCard(battleCards[i].cardList[j]);

                yield return new WaitForSeconds(0.01f);

                PrintBattleCard(i, j);

                yield return new WaitForSeconds(0.01f);
            }
        }

        isTakingScreenShots = false;
    }
    IEnumerator ScreenShot_AllActionCards()
    {
        for (int i = 0; i < actionCards.Count; i++)
        {
            battleUI_Parent.SetActive(false);
            actionUI_Parent.SetActive(true);
            clanSpecialtyUI_Parent.SetActive(false);
            eventUI_Parent.SetActive(false);

            //Each Iteration for each card in the List
            for (int j = 0; j < actionCards[i].actionCardList.Count; j++)
            {
                cardManager.DisplayActionCard(actionCards[i].actionCardList[j]);

                yield return new WaitForSeconds(0.01f);

                PrintActionCard(i, j);

                yield return new WaitForSeconds(0.01f);
            }
        }

        isTakingScreenShots = false;
    }
    IEnumerator ScreenShot_AllClanSpecialtyCards()
    {
        for (int i = 0; i < clanSpecialtyCards.Count; i++)
        {
            battleUI_Parent.SetActive(false);
            actionUI_Parent.SetActive(false);
            clanSpecialtyUI_Parent.SetActive(true);
            eventUI_Parent.SetActive(false);

            //Each Iteration for each card in the List
            for (int j = 0; j < clanSpecialtyCards[i].clanSpecialtyCardList.Count; j++)
            {
                cardManager.DisplayClanSpecialty(clanSpecialtyCards[i].clanSpecialtyCardList[j]);

                yield return new WaitForSeconds(0.01f);

                PrintClanSpecialtyCard(i, j);

                yield return new WaitForSeconds(0.01f);
            }
        }

        isTakingScreenShots = false;
    }
    IEnumerator ScreenShot_AllEventCards()
    {
        for (int i = 0; i < actionCards.Count; i++)
        {
            battleUI_Parent.SetActive(false);
            actionUI_Parent.SetActive(false);
            clanSpecialtyUI_Parent.SetActive(false);
            eventUI_Parent.SetActive(true);

            //Each Iteration for each card in the List
            for (int j = 0; j < eventCards[i].eventCardList.Count; j++)
            {
                cardManager.DisplayEventCard(eventCards[i].eventCardList[j]);

                yield return new WaitForSeconds(0.01f);

                PrintEventCard(i, j);

                yield return new WaitForSeconds(0.01f);
            }
        }

        isTakingScreenShots = false;
    }


    //--------------------


    void PrintBattleCard(int i, int j)
    {
        ScreenCapture.CaptureScreenshot(battleCards[i].cardList[j].cardType + "_" + battleCards[i].cardList[j].clan + "_" + battleCards[i].cardList[j].name + "_" + battleCards[i].cardList[j].loreInfo + ".png", 1);
        //print("Screen captured - Battle Card: " + i + " " + j);
    }
    void PrintActionCard(int i, int j)
    {
        if (actionCards[i].actionCardList[j].isInHiddenDeck)
        {
            ScreenCapture.CaptureScreenshot(actionCards[i].actionCardList[j].cardType + "_" + actionCards[i].actionCardList[j].name + " (Hidden) " + ".png", 1);
        }
        else
        {
            ScreenCapture.CaptureScreenshot(actionCards[i].actionCardList[j].cardType + "_" + actionCards[i].actionCardList[j].name + ".png", 1);
        }
        //print("Screen captured - Action Card: " + i + " " + j);
    }
    void PrintClanSpecialtyCard(int i, int j)
    {
        if (clanSpecialtyCards[i].clanSpecialtyCardList[j].version_Passive_A)
        {
            ScreenCapture.CaptureScreenshot(clanSpecialtyCards[i].clanSpecialtyCardList[j].cardType + "_" + clanSpecialtyCards[i].clanSpecialtyCardList[j].clan + "_" + clanSpecialtyCards[i].clanSpecialtyCardList[j].name + " (Passive A) " + ".png", 1);
        }
        else if (clanSpecialtyCards[i].clanSpecialtyCardList[j].version_Passive_B)
        {
            ScreenCapture.CaptureScreenshot(clanSpecialtyCards[i].clanSpecialtyCardList[j].cardType + "_" + clanSpecialtyCards[i].clanSpecialtyCardList[j].clan + "_" + clanSpecialtyCards[i].clanSpecialtyCardList[j].name + " (Passive B) " + ".png", 1);
        }
        else if (clanSpecialtyCards[i].clanSpecialtyCardList[j].version_Specialty_A)
        {
            ScreenCapture.CaptureScreenshot(clanSpecialtyCards[i].clanSpecialtyCardList[j].cardType + "_" + clanSpecialtyCards[i].clanSpecialtyCardList[j].clan + "_" + clanSpecialtyCards[i].clanSpecialtyCardList[j].name + " (Specialty A) " + ".png", 1);
        }
        else if (clanSpecialtyCards[i].clanSpecialtyCardList[j].version_Specialty_B)
        {
            ScreenCapture.CaptureScreenshot(clanSpecialtyCards[i].clanSpecialtyCardList[j].cardType + "_" + clanSpecialtyCards[i].clanSpecialtyCardList[j].clan + "_" + clanSpecialtyCards[i].clanSpecialtyCardList[j].name + " (Specialty B) " + ".png", 1);
        }
        else
        {
            ScreenCapture.CaptureScreenshot(clanSpecialtyCards[i].clanSpecialtyCardList[j].cardType + "_" + clanSpecialtyCards[i].clanSpecialtyCardList[j].clan + "_" + clanSpecialtyCards[i].clanSpecialtyCardList[j].name + ".png", 1);
        }

        //print("Screen captured - Can Specialty Card: " + i + " " + j);
    }
    void PrintEventCard(int i, int j)
    {
        ScreenCapture.CaptureScreenshot("Event_" + eventCards[i].eventCardList[j].name + ".png", 1);
        //print("Screen captured - Event Card: " + i + " " + j);
    }
}
