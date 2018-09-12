using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hotdogtruck : MonoBehaviour {

    public GameObject hotdog;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "money")
        {
            StartCoroutine( Delayed( other ) );
        }
    }

    private IEnumerator Delayed(Collider other)
    {
        Vector3 pos = other.transform.position;
        GetComponent<AudioSource>().Play();
        Destroy(other.gameObject);

        yield return new WaitForSeconds(1);

        GameObject newhotdog = Instantiate(hotdog, pos, Quaternion.identity);
        newhotdog.GetComponent<Rigidbody>().AddForce(transform.forward * 10, ForceMode.Impulse);

    }


}
