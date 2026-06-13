using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCounter2 : MonoBehaviour
{
    public CounterType kind = CounterType.Keys;
    public int startCount = 0;

    public static Dictionary<CounterType, int> counters = new Dictionary<CounterType, int>();

    void Start()
    {
        counters[kind] = startCount;
    }
}
public enum CounterType 
{
    Keys, Hearts, Miss, Score, Gold, ItemA, ItemB, ItemC
}