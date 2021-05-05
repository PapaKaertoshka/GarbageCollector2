using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Comparing : MonoBehaviour
{
	[SerializeField] private UnityEvent OnTrashCollected;
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
			OnTrashCollected?.Invoke();
			Destroy(other.gameObject);
		}
		else
		{
			StartCoroutine(SetText());
			other.gameObject.GetComponent<ItemBehaviour>().ReturnToPosition();
		}
	}
}
