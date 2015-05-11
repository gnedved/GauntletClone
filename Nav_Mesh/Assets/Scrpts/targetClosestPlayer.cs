using UnityEngine;
using System.Collections;

public class targetClosestPlayer : MonoBehaviour {

	public GameObject controller;
	public Transform target;
	public float distance = 0;
	public float closestDistance = 10000000;
	public int pos = 0;
	NavMeshAgent agent;
	
	private Master_Control master_control;
	
	// Use this for initialization
	void Start () {
        controller = GameObject.Find("Master_Controller_obj");
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		master_control = controller.GetComponent<Master_Control>(); 
		
		// cycles through the player array and stores the position of the farthest player
		for (int x = 0; x < master_control.players.Length; x++)
		{
            if (master_control.players[x] != null)
            { 
			    float distance = Vector3.Distance (master_control.players[x].transform.position, this.transform.position);
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    pos = x;
                }
			}
		
		}
        closestDistance = 10000000;
		//sets the enemies target to the player furthest from itself.
        target = master_control.players[pos].transform;
		agent.SetDestination (target.position);
	}
}
