using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Comparing : MonoBehaviour
{
	public int score;
	public LayerMask layer;
	public Text wrong;
	private IEnumerator SetText()
	{
		wrong.gameObject.SetActive(true);
		yield return new WaitForSeconds(2f);
		wrong.gameObject.SetActive(false);
	}
	void OnCollisionEnter(Collision other)
	{
		if (Mathf.Pow(2, other.gameObject.layer) == layer.value)
		{
			score++;
			Destroy(other.gameObject);
		}
		else
		{
			StartCoroutine(SetText());
			other.gameObject.GetComponent<ItemBehaviour>()?.ReturnToPosition();
		}
	}
}
