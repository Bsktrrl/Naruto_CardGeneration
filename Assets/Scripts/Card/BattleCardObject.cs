using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleCardObject : MonoBehaviour
{
    [Header("Design")]
    public Image outerFrame;
    public Image background_Image;

    public Image over_Circle;
    public Image over_Field;
    public Image over_Frame;
    public Image under_Circle;
    public Image under_Field;
    public Image under_Frame;

    [Header("Character")]
    public Image characterImage;

    [Header("Info Box")]
    public Image box_Frame;
    public TextMeshProUGUI name_Text;
    public TextMeshProUGUI loreInfo_Text;
    public Image landOrigins_Image;

    public GameObject effectText_Parent;
    public GameObject effectTextIcon_Parent;
    public GameObject effectIcon_Parent;

    //public GameObject states_Parent;
    //public List<GameObject> states_Image;

    public List<GameObject> effectIcons;
    public Image tier_Image;
    //public Image guard_Image;

    [Header("Value")]
    public Image Taijutsu_Border_Image;
    public Image Ninjutsu_Border_Image;
    public Image Genjutsu_Border_Image;

    [Header("Heal")]
    public Image Heal_Border_Image;
    public Image HealBlock_Border_Image;

    [Header("Heads")]
    public GameObject headParent;
    public List<GameObject> heads_Image;
    
    [Header("Values")]
    public TextMeshProUGUI taijutsuValue_Text;
    public TextMeshProUGUI ninjutsuValue_Text;
    public TextMeshProUGUI genjutsuValue_Text;

    [Header("Heal")]
    public GameObject healParent;
    public GameObject healBlockParent;
    public Image heal_Image;
    public Image healBlock_Image;

    [Header("Resources")]
    public List<GameObject> resources_Image;

    [Header("Card info")]
    public Image setImage;
    public TextMeshProUGUI infoText;
}
