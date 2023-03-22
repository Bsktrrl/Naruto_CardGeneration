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


    //--------------------


    private void Start()
    {
        cardManager = FindObjectOfType<CardManager>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
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
        StartCoroutine(AllCards(cardManager.battle_Senju));
    }

    IEnumerator AllCards(SO_NarutoCard battleCard)
    {
        for (int i = 0; i < battleCard.cardList.Count; i++)
        {
            cardManager.DisplayBattleCard(battleCard, i);

            yield return new WaitForSeconds(0.2f);

            ScreenCapture.CaptureScreenshot(battleCard.cardList[i].cardType + "_" + battleCard.cardList[i].clan + "_" + battleCard.cardList[i].name + "_" + battleCard.cardList[i].loreInfo + ".png", 1);
            print("Screen captured - Finished " + i);

            yield return new WaitForSeconds(0.8f);
        }
    }
}
