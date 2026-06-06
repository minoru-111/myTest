using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SometimeRandomCreatePrefab2 : MonoBehaviour
{
    public GameObject newPrefab;
    public float intervalSec = 1;
    public int newZ = -5;

    void Start()
    {
        InvokeRepeating("CreatePrefab", intervalSec, intervalSec);
    }

    void CreatePrefab()
    {
        Vector3 area = GetComponent<SpriteRenderer>().bounds.size;
        Vector3 newPos = transform.position;
        newPos.x += Random.Range(-area.x / 2, area.x / 2);
        newPos.y += Random.Range(-area.y / 2, area.y / 2);
        newPos.z = newZ;
        GameObject newGamePbject = Instantiate(newPrefab) as GameObject;
        newGamePbject.transform.position = newPos;
    }
}