using UnityEngine;
using System.Collections;
using DG.Tweening;

public class GrabUP : MonoBehaviour
{
	private Camera _camera;
	private Transform objectToGrab;
	private new Rigidbody objectRigidbody;

    private void Start()
    {
		_camera = Camera.main;
    }

    void FixedUpdate()
	{
		if (Input.GetMouseButton(0))
		{
			if (!objectToGrab)
			{
				Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
				if (Physics.Raycast(ray, out RaycastHit hit))
				{
					if (hit.rigidbody && !objectToGrab)
					{
						objectToGrab = hit.transform;
						objectRigidbody = objectToGrab.GetComponent<Rigidbody>();
						objectRigidbody.useGravity = false;
						objectRigidbody.velocity = Vector3.zero;
						objectToGrab.GetComponent<ItemBehaviour>().SavePosition();
					}
				}
			}
			else
			{
				Vector3 mousePosition = _camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, _camera.transform.position.y));
				objectToGrab.GetComponent<Rigidbody>().MovePosition(new Vector3(mousePosition.x, 25f, mousePosition.z));
			}
		}
		else if (objectToGrab)
		{
			objectRigidbody.useGravity = true;
			objectToGrab = null;
			objectRigidbody = null;
		}
	}
}