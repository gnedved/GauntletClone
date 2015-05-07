using UnityEngine;
using System.Collections;

public class Agent_Script : MonoBehaviour {

	public Transform goal;
	NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		agent.SetDestination (goal.position);
	}
}
