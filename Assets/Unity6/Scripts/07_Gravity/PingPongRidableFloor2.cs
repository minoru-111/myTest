using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongRidableFloor2 : MonoBehaviour
{
    public float speed = 1.0f;
    public float moveTime = 2.0f;

    Rigidbody2D rbody;
    private float timer = 0.0f;
    private List<GameObject> chidObjects = new List<GameObject>();

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        rbody.bodyType = RigidbodyType2D.Kinematic;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= moveTime)
        {
            speed = -speed;
            timer = 0.0f;
        }
        CheckRemove();
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        chidObjects.Add(other.gameObject);
        other.gameObject.transform.parent = transform;
    }

    private void CheckRemove()
    {
        List<GameObject> removeList = new List<GameObject>();
        foreach (GameObject obj in chidObjects)
        {
            Collider2D childcol = obj.GetComponent<Collider2D>();
            Collider2D floorcol = GetComponent<Collider2D>();
            if (!Physics2D.IsTouching(childcol, floorcol))
            {
                obj.transform.parent = null;
                removeList.Add(obj);
            }
        }
        foreach (GameObject obj in removeList)
        {
            chidObjects.Remove(obj);
        }
    }
}