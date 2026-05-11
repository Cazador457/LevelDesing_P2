using UnityEngine;

public class CursorShow : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true;

        Cursor.lockState = CursorLockMode.None;
    }

    void Update()
    {
        if (!Cursor.visible)
            Cursor.visible = true;

        if (Cursor.lockState != CursorLockMode.None)
            Cursor.lockState = CursorLockMode.None;
    }
}
