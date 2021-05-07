using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ItemBehaviour : MonoBehaviour
{
	private new Rigidbody rigidbody;
	private Vector3 returnPosition = Vector3.zero;
	private void Start()
	{
		rigidbody = GetComponent<Rigidbody>();
		returnPosition = transform.position;
	}
	private void FixedUpdate()
	{
		Vector3 screenPoint = Camera.main.WorldToViewportPoint(gameObject.transform.position);
		if (screenPoint.x < 0 || screenPoint.x > 1)
		{
			rigidbody.velocity = new Vector3(rigidbody.velocity.x * (-1), rigidbody.velocity.y, rigidbody.velocity.z);
		}
		if (screenPoint.y < 0 || screenPoint.y > 1)
		{
			rigidbody.velocity = new Vector3(rigidbody.velocity.x, rigidbody.velocity.y * (-1), rigidbody.velocity.z);
		}
		if (screenPoint.z < 0 || screenPoint.z > 1)
		{
			rigidbody.velocity = new Vector3(rigidbody.velocity.x, rigidbody.velocity.y, rigidbody.velocity.z * (-1));
		}
		if (transform.position.y < -20)
        {
			transform.position = new Vector3(transform.position.x, 5, transform.position.y);
        }
	}
	public void SavePosition()
	{
		if (returnPosition == Vector3.zero)
		{
			returnPosition = gameObject.transform.position;
		}
	}
	public void ReturnToPosition()
	{
		transform.DOMove(returnPosition, 2f);
	}
}
