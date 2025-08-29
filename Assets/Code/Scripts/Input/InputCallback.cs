using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputCallback : MonoBehaviour, Controls.IPlayerMoveActions
{
    private Controls controls;

    public Vector2 InputMove { get; private set; }
    public bool InputDash { get; private set; }

    private void Awake()
    {
        controls = new Controls();
        controls.PlayerMove.AddCallbacks(this);
        controls.Enable();   
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        InputMove = context.ReadValue<Vector2>();
    }

    public void OnDash(InputAction.CallbackContext context)
    {
        InputDash = true;

        if (context.canceled)
            InputDash = false;
    }
}
