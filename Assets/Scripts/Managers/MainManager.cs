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
    }

    void Screenhot()
    {
        StartCoroutine(AllCards());
    }

    IEnumerator AllCards()
    {
        for (int i = 0; i < cardManager.battle_Senju.cardList.Count; i++)
        {
            cardManager.DisplayCard(i);

            yield return new WaitForSeconds(0.2f);

            ScreenCapture.CaptureScreenshot(cardManager.battle_Senju.cardList[i].cardType + "_" + cardManager.battle_Senju.cardList[i].clan + "_" + cardManager.battle_Senju.cardList[i].name + "_" + cardManager.battle_Senju.cardList[i].loreInfo + ".png", 1);
            print("Screen captured - Finished " + i);

            yield return new WaitForSeconds(0.8f);
        }
    }
}
