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
    public ScriptableEgg[] eggDataList;


    //  Listen for space key and lay eggs
    public void LayEgg(InputAction.CallbackContext action)
    {
        if (action.phase == InputActionPhase.Performed)
        {
            var eggData = eggDataList[Random.Range(0, eggDataList.Length)];
            var newEgg = Instantiate(eggData.prefab, eggSpawnPoint.position, Quaternion.identity);
            newEgg.transform.localScale = new Vector2(eggData.eggSize, eggData.eggSize);
        }
    }
}