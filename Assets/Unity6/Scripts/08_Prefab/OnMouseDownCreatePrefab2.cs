using UnityEngine;
using UnityEngine.InputSystem;

public class OnMouseDownCreatePrefab2 : MonoBehaviour
{
    public GameObject newPrefab;

    public int newZ = -5;

    void Update()
    {
        if (Pointer.current != null && Pointer.current.press.wasPressedThisFrame)
        {
            Vector2 screenPos = Pointer.current.position.ReadValue();
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(
                new Vector3(screenPos.x, screenPos.y, Camera.main.nearClipPlane));    
            worldPos.z = newZ;
            Instantiate(newPrefab, worldPos, Quaternion.identity);
        }
    }
}