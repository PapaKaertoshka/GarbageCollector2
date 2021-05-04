using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Comparing : MonoBehaviour
{
	public int lay, score;
	public Text wrong;
	private IEnumerator SetText()
	{
		wrong.gameObject.SetActive(true);
		yield return new WaitForSeconds(2f);
		wrong.gameObject.SetActive(false);
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.layer == lay)
		{
			score++;
		}
		else
		{
			StartCoroutine(SetText());
			score--;
		}
		Destroy(other.gameObject);
	}
}
