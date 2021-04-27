using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingName : MonoBehaviour
{
    public string objName = null;
    public GameObject oth;
    void Start()
    {
        objName = null;
    }
    void OnCollisionEnter(Collision other)
    {
        oth = other.gameObject;
        objName = other.gameObject.name;
    }
    void OnCollisionExit()
    {
        objName = null;
    }
}
