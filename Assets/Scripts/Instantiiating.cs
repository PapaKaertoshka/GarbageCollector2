using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiiating : MonoBehaviour
{
    [SerializeField] GameObject[] objects;
    public float dispersion = 1f;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        for (int i = 0; i < objects.Length; i++)
        {
            Vector3 tempX = Vector3.right * Random.Range(-dispersion, dispersion) * 3;
            Vector3 tempZ = Vector3.forward * Random.Range(-dispersion, dispersion) * 5;
            Vector3 newPosition = transform.position + tempX + tempZ;
            GameObject garbage = Instantiate(objects[i], newPosition, Quaternion.identity, transform);
            garbage.GetComponent<Rigidbody>().velocity = (tempX + tempZ + Vector3.down * 2);
            yield return new WaitForSeconds(0.1f);
        }
    }
}