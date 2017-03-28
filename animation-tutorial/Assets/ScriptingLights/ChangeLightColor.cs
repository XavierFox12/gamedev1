using UnityEngine;
using System.Collections;

public class ChangeLightColor : MonoBehaviour {

	private Color oldLightColor = Color.white;
	public Color lightColor = new Color(1f, 0f, 0f, 1f);
	public Light targetLight;

	void Update()
	{
		Color materialColor = lightColor;
		Material mat = GetComponent<MeshRenderer> ().sharedMaterial;
		materialColor.a = (Mathf.Sin(Time.time) + 1) * .5f;
		/*materialColor = new Color(Mathf.Sin (Time.time) * materialColor.r,
			Mathf.Sin (Time.time) * materialColor.g,
			Mathf.Sin (Time.time) * materialColor.b,
			Mathf.Sin (Time.time) * materialColor.a);*/
		mat.color = materialColor;
	}

	void OnTriggerEnter(Collider other)
	{
		oldLightColor = targetLight.color;
		targetLight.color = lightColor;
	}

	void OnTriggerExit(Collider other)
	{
		targetLight.color = oldLightColor;
	}
}
