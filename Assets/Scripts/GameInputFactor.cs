using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameInputFactor : MonoBehaviour
{
    public event EventHandler OnInteractAction;

    private PlayerInputActions playerInputActions;

    private void Awake()
    {
        playerInputActions =  new PlayerInputActions();
        playerInputActions.Player.Enable();

        playerInputActions.Player.Interact.performed += Interact_performed;
    }

    private void Interact_performed(InputAction.CallbackContext obj)
    {
        /*if (OnInteractAction != null)
        {
            OnInteractAction(this, EventArgs.Empty);
        }*/
        OnInteractAction?.Invoke(this, EventArgs.Empty);
    }

    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();

        inputVector = inputVector.normalized;

        return inputVector;
    }
}
