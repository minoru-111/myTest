using UnityEngine;
using UnityEngine.InputSystem;

// タッチしたら、回転する
public class OnMouseDownRotate2 : MonoBehaviour
{
    public float angle = 360;

    private float rotateAngle = 0;

    void Update()
    {
        if (Mouse.current?.leftButton.wasPressedThisFrame == true)
        {
            var ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            var hit = Physics2D.GetRayIntersection(ray, 100f, 1 << gameObject.layer);
            if (hit.collider && hit.collider.gameObject == gameObject)
               rotateAngle = angle;
        }

        if (Mouse.current?.leftButton.wasReleasedThisFrame == true)
        {
            rotateAngle = 0;
        }
    }

    void FixedUpdate()
    {
        transform.Rotate(0, 0, rotateAngle * Time.deltaTime);
    }
}