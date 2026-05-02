using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]

public class OnKeyPressMoveSprite2 : MonoBehaviour
{
    public float speed = 5f;

    private Vector2 moveinput;

    private SpriteRenderer sr;

    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    public void OnMove(InputValue value)
    {
        moveinput = value.Get<Vector2>();

        if (moveinput.x != 0) sr.flipX = moveinput.x < 0;
    }

    void FixedUpdate()
    {
        Vector2 delta = moveinput * speed * Time.fixedDeltaTime;
        transform.Translate(delta.x, delta.y,0);
    }


}