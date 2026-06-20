using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionPlaySE2 : MonoBehaviour
{
    public GameObject targetObject;
    public string tagName;
    public AudioClip se;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == targetObject || collision.gameObject.tag == tagName)
        {
            gameObject.GetComponent<AudioSource>().PlayOneShot(se);
        }
    }
}