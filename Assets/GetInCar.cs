using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInCar : MonoBehaviour
{
    public BoxCollider bc;
    public GameObject car;
    carcontroller controller;
    public GameObject player;
    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        car.GetComponent<carcontroller>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerStay  (Collider other)
	{
        
		if (other.gameObject.name == "Assault_Rifle_01_FPSController")
		{
            Debug.Log("Press m");
            if (Input.GetKeyDown("m"))
			{
                car.GetComponent<carcontroller>().enabled = true;
                player.SetActive(false);
                cam.SetActive(true);
            }
        }
    }
}
