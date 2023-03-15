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
    public List<Image> heads_Image;

    [Header("Status")]
    public Image heal_Image;

    [Header("Resources")]
    public List<Image> resources_Image;

    [Header("Effect")]
    public TextMeshProUGUI effect_Text;
    public List<Image> states_Image;
    public Image tier_Image;
    public Image guard_Image;


    //Stats - Head
    //When there are different amount of heads, the width should be different
    //5 heads: w760
    //4 heads: w600
    //3 heads: w440
    //2 heads: w280
    //1 heads: w120
}
