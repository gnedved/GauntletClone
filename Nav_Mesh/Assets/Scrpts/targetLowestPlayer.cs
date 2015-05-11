﻿using UnityEngine;
using System.Collections;

public class targetLowestPlayer : MonoBehaviour {

	public GameObject controller;
	public Transform target;
	public int pos = 0;
	NavMeshAgent agent;

	private Master_Control master_control;

	// Use this for initialization
	void Awake () {
        controller = GameObject.Find("Master_Controller_obj");
        Debug.Log(controller);
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		master_control = controller.GetComponent<Master_Control>(); 

		// cycles through the health array and stores the position of the lowest value
		for (int i = 0; i < master_control.healths.Length; i++)
		{
            if (master_control.healths[i] != 0)
            {
                if (master_control.healths[i] < master_control.healths[pos]) 
                { 
				    pos = i; 
			    }
            }
			
		}
		//sets the enemies target to the player in the player array slot respective to the lowest health array slot.
		target = master_control.players [pos].transform;
		agent.SetDestination (target.position);
		Debug.Log (this.pos);
		Debug.Log (target.position);
	}
}
