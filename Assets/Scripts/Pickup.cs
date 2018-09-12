using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {


    public Transform hand;
    public Rigidbody rigidbody;

	// Use this for initialization
	void Start () {

        rigidbody = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        rigidbody.useGravity = false;
        transform.position = hand.position;
        transform.parent = hand;
        rigidbody.isKinematic = true;

    }

    private void OnMouseUp()
    {
        transform.parent = null;
        rigidbody.useGravity = true;
        rigidbody.isKinematic = false;
        rigidbody.AddForce(Camera.main.transform.forward * 15, ForceMode.Impulse);
    }
}
