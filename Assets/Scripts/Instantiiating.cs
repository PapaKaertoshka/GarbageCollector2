using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiiating : MonoBehaviour
{
    [SerializeField] GameObject[] objects;
    void Start()
    {
        for (int i = 0; i < objects.Length; i++)
        {
            Instantiate(objects[i], transform.position, Quaternion.identity, transform);
        }
    }
}