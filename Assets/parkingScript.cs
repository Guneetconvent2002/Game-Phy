using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parkingScript : MonoBehaviour
{
	public GameObject car;
	public GameObject plate;
	private Renderer renderer;

	private void Start()
	{
		renderer = plate.GetComponent<Renderer>();
	}

	private void OnTriggerStay(Collider other)
	{
		if(other.gameObject == car)
		{
			Debug.Log("Parked!!");
			renderer.material.SetColor("_Color", new Color(0, 256, 0));
		}
    }
}
