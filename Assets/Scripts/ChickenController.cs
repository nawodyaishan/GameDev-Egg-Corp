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
    public Transform eggSpawnPoint;
    public GameObject eggPrefab1;
    
    
    //  Listen for space key and lay eggs
    public void LayEgg(InputAction.CallbackContext action)
    {
        if (action.phase == InputActionPhase.Performed)
        {
            Instantiate(eggPrefab1, eggSpawnPoint.position, Quaternion.identity);
        }
    }
}
