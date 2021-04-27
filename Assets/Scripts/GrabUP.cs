using UnityEngine;
using System.Collections;
using DG.Tweening;

public class GrabUP : MonoBehaviour
{
	Quaternion originRotation;
	public Camera _camera;
	public float step = 5; // шаг для изменения высоты в 3D
	private Transform curObj;
	private float mass;
	void FixedUpdate()
	{

		if (Input.GetMouseButton(0))
		{
			Quaternion rotationY = Quaternion.AngleAxis(30, Vector3.up);
			Quaternion rotationX = Quaternion.AngleAxis(-30, Vector3.right);
			RaycastHit hit;
			Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
				if (Physics.Raycast(ray, out hit))
				{
					if ( hit.rigidbody && !curObj)
					{
						curObj = hit.transform;
						mass = curObj.GetComponent<Rigidbody>().mass;
						curObj.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
						curObj.GetComponent<Rigidbody>().useGravity = false;
					}
				}

				if (curObj)
				{
					Vector3 mousePosition = _camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, _camera.transform.position.y));
					curObj.GetComponent<Rigidbody>().MovePosition(new Vector3(mousePosition.x, 14f, mousePosition.z));
					curObj.DORotate(Quaternion.identity.eulerAngles, 1.5f, RotateMode.Fast);
			}
		}
		else if (curObj)
		{
			if (curObj.GetComponent<Rigidbody>())
			{
				curObj.rotation = Quaternion.identity;
				curObj.GetComponent<Rigidbody>().useGravity = true;
				curObj.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
			}
			curObj = null;
		}
	}
}