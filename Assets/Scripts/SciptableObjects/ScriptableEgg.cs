using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Egg", menuName = "Data/Egg")]
public class ScriptableEgg : ScriptableObject
{
    public string eggName;
    public GameObject prefab;
    public float eggSize = 1f;
}
