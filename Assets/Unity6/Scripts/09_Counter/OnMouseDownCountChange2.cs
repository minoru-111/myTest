using UnityEngine;
using UnityEngine.InputSystem;

public class OnMouseDownCountChange2 : MonoBehaviour
{
    private CounterType2 kind = CounterType2.Keys;
    public int addValue = 1;

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            var ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            var hit = Physics2D.GetRayIntersection(ray, 100f, 1 << gameObject.layer);
            if (hit.collider && hit.collider.gameObject == gameObject)
            {
                GameCounter2.counters[kind] = GameCounter2.counters[kind] + addValue;
            }
        }
    }
}