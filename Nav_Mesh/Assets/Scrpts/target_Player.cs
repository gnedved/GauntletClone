using UnityEngine;
using System.Collections;

public class target_Player : MonoBehaviour {

    public GameObject controller;
    public Transform target;
    public int pos = 0;
    public float distance = 0;
    public float closestDistance = 10000000;
    NavMeshAgent agent;
    public int enemyType;

    private Master_Control master_control;

	// Use this for initialization
	void Start () 
    {
        controller = GameObject.Find("Master_Controller_obj");
	    agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () 
    {
        master_control = controller.GetComponent<Master_Control>();

        // cycles through the players array
        for (int x = 0; x < master_control.players.Length; x++)
        {
            if (master_control.players[x] != null)
            {
                //based on enemy type, the enemy will target the highest health, lowest health, or closest
                if (enemyType == 0)
                {
                    if (master_control.healths[x] > master_control.healths[pos])
                    {
                        pos = x;
                        
                    }
                }
                
                if (enemyType == 1)
                {
                    
                    if (master_control.healths[x] < master_control.healths[pos])
                    {
                        pos = x;
                       
                    }
                }
                if (enemyType == 2)
                {
                    float distance = Vector3.Distance(master_control.players[x].transform.position, this.transform.position);
                    if (distance < closestDistance)
                    {
                        closestDistance = distance;
                        pos = x;
                        
                    }
                }
            }
        }
       
        //sets the enemies target to the player in the player array slot respective to the highest health array slot.
        target = master_control.players[pos].transform;
        agent.SetDestination(target.position);
        pos = 0;
        closestDistance = 10000000;

	}
}
