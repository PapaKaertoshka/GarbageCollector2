using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiiating : MonoBehaviour
{
    [SerializeField] GameObject[] objects;
    private IEnumerator SpawnCubes()
    {
        for (int i = 0; i < objects.Length; i++)
        {
            Instantiate(objects[i], transform.position, Quaternion.identity);
        }
        yield return new WaitForSeconds(2f);
    }
    void Start()
    {
        StartCoroutine(SpawnCubes());
    }
}