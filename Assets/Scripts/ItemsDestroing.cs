using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ItemsDestroing : MonoBehaviour
{
    public GameObject inpos;
    void Update()
    {
        if(transform.position.y <= -80)
        {
            transform.position = inpos.transform.position; 
        }
    }
}
