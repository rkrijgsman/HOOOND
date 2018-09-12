using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTriggerEnter : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "ai")
            Destroy(other.gameObject);
    }
}
