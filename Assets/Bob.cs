using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bob : MonoBehaviour
{
    Vector3 v;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(v / 2000);
    }
	private void OnTriggerEnter(Collider other)
	{
        v = other.gameObject.GetComponent<Rigidbody>().velocity;
	}
}
