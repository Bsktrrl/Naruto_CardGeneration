using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardObject : MonoBehaviour
{
    [Header("Clan")]
    public List<Image> background_Image;
    public Image Frame_Image;
    public Image Box_Image;

    [Header("Character")]
    public Image characterImage;

    [Header("Name")]
    public TextMeshProUGUI name_Text;
    public TextMeshProUGUI loreInfo_Text;
    public List<Image> landOrigins_Image;

    [Header("Heads")]
    public GameObject headParent;
    public List<GameObject> heads_Image;
    
    [Header("Values")]
    public TextMeshProUGUI taijutsuValue_Text;
    public TextMeshProUGUI ninjutsuValue_Text;
    public TextMeshProUGUI genjutsuValue_Text;

    [Header("Status")]
    public GameObject healParent;
    public Image heal_Image;

    [Header("Resources")]
    public List<Image> resources_Image;

    [Header("Effect")]
    public TextMeshProUGUI effect_Text;
    public List<GameObject> states_Image;
    public Image tier_Image;
    public Image guard_Image;
}
