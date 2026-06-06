using System.Collections;
using System.Collections.Generic;
using UnityEditor.Media;
using UnityEngine;

public class ForeverMoveH2 : MonoBehaviour
{
    public float speed = 1;

    void FixedUpdate()
    {
        transform.Translate(speed * Time.deltaTime, 0,0);
    }
}