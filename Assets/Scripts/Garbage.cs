using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Garbage", menuName = "Garbage")]
public class Garbage : ScriptableObject
{
    public Mesh mesh;
    public LayerMask layer;
}
