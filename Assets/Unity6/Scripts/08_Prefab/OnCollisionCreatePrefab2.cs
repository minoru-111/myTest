using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionCreatePrefab2 : MonoBehaviour
{
    public GameObject targetObject;
    public string tagName;
    public GameObject newPrefab;
    public int newZ = -5;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == targetObject || collision.gameObject.tag == tagName)
        {
            GameObject newGameObject = Instantiate(newPrefab) as GameObject;
            Vector3 pos = collision.contacts[0].point;
            pos.z = newZ;
            newGameObject.transform.position = pos;
        }
    }
}