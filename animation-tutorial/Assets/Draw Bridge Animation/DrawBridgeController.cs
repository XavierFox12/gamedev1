using UnityEngine;
using System.Collections;

public class DrawBridgeController : MonoBehaviour {

	public Animator animator;

	public void OnTriggerEnter(Collider collider)
	{
		OpenDoor ();
	}

	public void OnTriggerExit(Collider collider)
	{
		CloseDoor ();
	}

	public void OpenDoor()
	{
		animator.SetBool ("IsOpen", true);
		animator.SetBool ("IsClosed", false);
	}

	public void CloseDoor()
	{
		animator.SetBool ("IsOpen", false);
		animator.SetBool ("IsClosed", true);
	}
}
