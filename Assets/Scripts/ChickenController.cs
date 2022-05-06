using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Writing Main Script for Chicken Controller
/// </summary>
public class ChickenController : MonoBehaviour
{
    // Listen for movement keys and move
    
    
    
    //  Listen for space key and lay eggs
    public void LayEgg(InputAction.CallbackContext action)
    {
        if (action.phase == InputActionPhase.Performed)
        {
            Debug.Log("Egg Laid!");    
        }
    }
}
