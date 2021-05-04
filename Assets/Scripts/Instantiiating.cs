using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiiating : MonoBehaviour
{
    [SerializeField] GameObject[] objects;
    public GameObject wall, wall2;
    private IEnumerator SpawnCubes()
    {
        for (int i = 0; i < objects.Length; i++)
        {
            Instantiate(objects[i], transform.position, Quaternion.identity);
        }
        yield return new WaitForSeconds(2f);
        wall.SetActive(false);
        wall2.SetActive(false);
    }
    void Start()
    {
        StartCoroutine(SpawnCubes());
    }
}