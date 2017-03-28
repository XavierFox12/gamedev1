using UnityEngine;
using System.Collections;

public class SpinAndBounce : MonoBehaviour {

	float origionalPosition;
	public float speed = 1f;
	public float travel = .5f;
	public float rotateSpeed = 1f;

	void Start()
	{
		origionalPosition = transform.position.y;
	}

	void Update()
	{
		Vector3 cubePosition = transform.position;
		Vector3 cubeRotation = transform.rotation.eulerAngles;
		cubePosition.y = (Mathf.Sin (Time.time * speed) * travel) + origionalPosition;
		transform.position = cubePosition;

		cubeRotation.y = 360 * (Mathf.Sin(Time.time * rotateSpeed) + 1f) / 2f;
		transform.rotation = Quaternion.Euler (cubeRotation);
	}
}
