using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{

	public Transform camera;
	
	void Update ()
	{
		float cameraY = camera.rotation.y;
		transform.rotation = new Quaternion(0, -cameraY - 90, 0, 0);
	}
}
