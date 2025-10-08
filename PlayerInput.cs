using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public Vector2 mousePosition;
    public Mouse currentMouse;

    private void Start()
    {
        currentMouse = Mouse.current;
    }
    private void Update()
    {
        mousePosition = currentMouse.position.ReadValue();
        //Debug.Log(mousePosition);
    }
}
