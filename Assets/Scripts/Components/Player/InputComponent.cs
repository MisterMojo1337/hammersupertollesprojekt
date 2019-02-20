using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

public class InputComponent : MonoBehaviour
{
    [SerializeField] private InputMaster inputMaster;
    [SerializeField] private MovementComponent movement;
    
    void Awake()
    {
        inputMaster.Player.Movement.performed += MovementInput;
    }

    void MovementInput(InputAction.CallbackContext context)
    {
        movement.SetMoveInput(context.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        inputMaster.Player.Movement.Enable();
    }

    private void OnDisable()
    {
        inputMaster.Player.Movement.Disable();
    }

    private void OnDestroy()
    {
        inputMaster.Player.Movement.performed -= MovementInput;
    }
}
