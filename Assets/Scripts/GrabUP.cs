using UnityEngine;
using System.Collections;
using DG.Tweening;

public class GrabUP : MonoBehaviour
{
	private Camera _camera;
	public float step = 5; // шаг для изменения высоты в 3D
	private Transform objectToGrab;

    private void Start()
    {
		_camera = Camera.main;
    }

    void FixedUpdate()
	{
		if (Input.GetMouseButton(0))
		{
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
			{
				if (hit.rigidbody && !objectToGrab)
				{
					objectToGrab = hit.transform;
					objectToGrab.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
					objectToGrab.GetComponent<Rigidbody>().useGravity = false;
					objectToGrab.GetComponent<ItemBehaviour>()?.SavePosition();
				}
			}
			if (objectToGrab)
			{
				Vector3 mousePosition = _camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, _camera.transform.position.y));
				objectToGrab.GetComponent<Rigidbody>().MovePosition(new Vector3(mousePosition.x, 25f, mousePosition.z));
				objectToGrab.DORotate(Quaternion.identity.eulerAngles, 1.5f, RotateMode.Fast);
			}
		}
		else if (objectToGrab)
		{
			if (objectToGrab.GetComponent<Rigidbody>())
			{
				objectToGrab.rotation = Quaternion.identity;
				objectToGrab.GetComponent<Rigidbody>().useGravity = true;
				objectToGrab.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
			}
			objectToGrab = null;
		}
	}
}