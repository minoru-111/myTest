using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ForeverShowCountPro2: MonoBehaviour
{
    private CounterType2 kind = CounterType2.Keys;


    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = GameCounter2.counters[kind].ToString();
    }
}