using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoulsTaken : MonoBehaviour
{
    public int Souls;

    public Text SoulsDisplay;

    public void ClickSouls()
    {
        Souls += 1;

        SoulsDisplay.text = "" + Souls;
        

    }
}
