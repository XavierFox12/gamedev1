using UnityEngine;
using System.Collections;

public class DoorController : MonoBehaviour {

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
		animator.SetInteger ("Door Open", 1);
		animator.SetInteger ("Door Close", 0);
	}

	public void CloseDoor()
	{
		animator.SetInteger ("Door Open", 0);
		animator.SetInteger ("Door Close", 1);
	}
}
