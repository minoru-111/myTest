using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionCountChangeDestroyMe2 : MonoBehaviour
{
    public GameObject targetObject;
    public string tagName;
    public CounterType2 kind = CounterType2.Keys;
    public int addValue = 1;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == targetObject || collision.gameObject.tag == tagName)
        {
            GameCounter2.counters[kind] = GameCounter2.counters[kind] + addValue;
            Destroy(gameObject);
        }
    }
}