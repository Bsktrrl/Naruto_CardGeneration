using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Screenhot();
        }
    }

    void Screenhot()
    {
        print("Screen captured - Started");
        ScreenCapture.CaptureScreenshot("Screenshot_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".png", 1);
        print("Screen captured - Finished");
    }
}
