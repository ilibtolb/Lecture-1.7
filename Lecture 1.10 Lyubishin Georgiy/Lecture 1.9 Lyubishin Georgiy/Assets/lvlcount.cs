using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lvlcount : MonoBehaviour
{

    public Text textlvl;
    public int lvlnumber;
    void Update()
    {
        textlvl.text = "Current level is: " + lvlnumber;
    }
}
