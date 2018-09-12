using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hotdogpoints : MonoBehaviour {

    public int score;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "hotdog")
        {
            score = score + 50;
            GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);

        }
          
    }
}
