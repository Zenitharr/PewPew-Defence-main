using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LivesUI : MonoBehaviour
{
    public TextMeshProUGUI livestext;

    void Update()
    {
        livestext.SetText(playerstats.Lives.ToString()+ " Lives");
    }
}
