using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCountFinishedHide2 : MonoBehaviour
{
    public CounterType2 kind = CounterType2.Keys;
    public int lastCount = 3;
    public GameObject hideObject;

    void Update()
    {
        if (GameCounter2.counters[kind] == lastCount)
        {
            hideObject.SetActive(false);
        }
    }
}