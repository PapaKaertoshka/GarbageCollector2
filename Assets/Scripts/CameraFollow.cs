using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    Transform center;
    public float radius = 7f;
    void Update()
    {
        transform.position = center.position;
        transform.rotation = center.rotation;
    }
}