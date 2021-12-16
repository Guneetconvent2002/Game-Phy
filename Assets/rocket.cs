using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject smoke;
    public GameObject flame;
    bool inc = false;
    public float acc = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        flame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (inc)
		{
            rb.AddForce(Vector3.up * acc);
		}
    }

	private void OnTriggerEnter(Collider other)
	{
            smoke.SetActive(false);
            flame.SetActive(true);
            StartCoroutine(DespawnTimer());
            inc = true;    
    }
    private IEnumerator DespawnTimer()
    {
        //Wait for set amount of time
        yield return new WaitForSeconds(10000f);
    }
}
