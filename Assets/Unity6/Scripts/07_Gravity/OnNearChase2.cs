using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnNearChase2 : MonoBehaviour
{
    public GameObject targetObject;
    public float speed = 3;
    public float limitDistance = 5;
    public bool gravityFlag = true;

    Rigidbody2D rbody;
    bool flipFlag = false;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        if (gravityFlag == false)
        {
            rbody.gravityScale = 0;
        }
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void FixedUpdate()
    {
        float distance = Vector2.Distance(transform.position, targetObject.transform.position);
        if (distance <= limitDistance)
        {
            Vector2 direction = (targetObject.transform.position - transform.position).normalized;
            if (gravityFlag == true)
            {
                rbody.linearVelocity = new Vector2(direction.x * speed, rbody.linearVelocity.y);
            }
            else
            {
                rbody.linearVelocity = direction * speed;
            }
        }
        else
        {
            if (gravityFlag == true)
            {
                rbody.linearVelocity = new Vector2(0, rbody.linearVelocity.y);
            }
            else
            {
                rbody.linearVelocity = Vector2.zero;
            }
        }
        if (rbody.linearVelocity.x > 0)
        {
            flipFlag = false;
        }
        if (rbody.linearVelocity.x < 0)
        {
            flipFlag = true;
        }
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        sprite.flipX = flipFlag;
    }
}