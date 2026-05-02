using UnityEngine;
using UnityEngine.InputSystem;

public class OnMouseDownRoulette2 : MonoBehaviour
{
    public float maxSpeed = 50;
    private float rotateAngle = 0;
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            var ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            var hit = Physics2D.GetRayIntersection(ray, 100f, 1 << gameObject.layer);
            if (hit.collider && hit.collider.gameObject == gameObject)
             {
                rotateAngle = maxSpeed;
            }
        }
    }

    void FixedUpdate()
    {
        rotateAngle *= 0.98f;
        transform.Rotate(0, 0, rotateAngle);
    }
}