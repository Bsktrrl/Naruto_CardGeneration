using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ActionCardObject : MonoBehaviour
{
    public TextMeshProUGUI name;
    public TextMeshProUGUI description;
    public TextMeshProUGUI type;

    public List<GameObject> coin;
    public Image icon;

    public GameObject fireBlock;
    public GameObject strength;
}
