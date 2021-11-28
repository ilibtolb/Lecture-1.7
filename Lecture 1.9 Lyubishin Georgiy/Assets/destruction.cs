using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destruction : MonoBehaviour
{
    public Text textcount;
    public int count;

    private void Update()
    {
        textcount.text = "Platforms destroyed: " + count.ToString();
    }
}
