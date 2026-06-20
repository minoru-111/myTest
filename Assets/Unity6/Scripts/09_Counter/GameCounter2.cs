using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCounter2 : MonoBehaviour
{
    private CounterType2 kind = CounterType2.Keys;
    public int startCount = 0;

    public static Dictionary<CounterType2, int> counters = new Dictionary<CounterType2, int>();

    void Start()
    {
        counters[kind] = startCount;
    }
}
public enum CounterType2 {
    Keys, Hearts, Miss, Score, Gold, ItemA, ItemB, ItemC
}