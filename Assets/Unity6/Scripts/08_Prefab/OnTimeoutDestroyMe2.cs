using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTimeoutDestroyMe2 : MonoBehaviour
{
    public float limitSec = 3;

    void Start()
    {
        Destroy(gameObject, limitSec);
    }
}