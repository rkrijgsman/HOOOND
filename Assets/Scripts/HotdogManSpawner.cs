using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotdogManSpawner : MonoBehaviour
{
    public float startDelay;
    public float spawnInterval;
    public GameObject Man;
    
    IEnumerator Start ()
    {
        yield return new WaitForSeconds(startDelay);
        while (gameObject.activeInHierarchy)
        {
            Instantiate(Man, transform.position, Quaternion.identity).SetActive(true);
            yield return new WaitForSeconds(spawnInterval);
        }
	}
	
}
