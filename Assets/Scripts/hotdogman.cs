using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class hotdogman : MonoBehaviour {

    public NavMeshAgent agent;
    public Transform foodtruck;
    public Transform fence;
    private Animator walk;

    public GameObject money;
    public float buyTimer;
    private float random;
    private bool spawned;

    public Transform holder;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(foodtruck.position);
        walk = GetComponent<Animator>();
        walk.SetFloat("Forward", 0.5f);

        random = Random.value * 30;
	}
	
	// Update is called once per frame
	void Update () {
        walk.SetFloat("Forward", Mathf.Min(0.5f, agent.remainingDistance ));

        random -= Time.deltaTime;
        if (random <= 0 && spawned == false)
        {
            Instantiate(money, transform.position, Quaternion.AngleAxis( 90, Vector3.right));
            spawned = true;
        }
        if (agent.remainingDistance < 0.1)
        {
            buyTimer = buyTimer - Time.deltaTime;
            holder.GetChild(0).gameObject.SetActive(buyTimer > 0);
            holder.GetChild(1).gameObject.SetActive(buyTimer < 0);
            if (buyTimer < 0)
                agent.SetDestination(fence.position);
        }
    }
}
