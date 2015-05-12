using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Timers;



public class Spawner : MonoBehaviour {

    public GameObject Lobber;
    public GameObject Goblin;
    public float Health = 100.0f;
    public bool isactive = false;
    public bool canSpawn = true;
    System.Timers.Timer spawnTimer = new System.Timers.Timer();
    
    
    
    //spawn enemy type
    // set timer for spawning
    // spawn
    void Start()
    {
        if (isactive == true)
        {
            string name = this.transform.name;
            if (name == "Lobber_Spawner")
            {
                Instantiate(Lobber, this.transform.position, Quaternion.identity);
            }
            if (name == "Goblin_Spawner")
            {
                Instantiate(Goblin, this.transform.position, Quaternion.identity);
            }
            
            isactive = false;

        }
        spawnTimer.Interval = 15 * 1000;

        spawnTimer.Start();

        spawnTimer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
    }

    private void timer_Elapsed(object sender, ElapsedEventArgs e)
    {
        canSpawn = true;
        spawnTimer.Start();

       

    }
    void Update()
    {
        if (Health <= 0)
        {
            Destroy(this.gameObject);
            //I think there was a reason for moving and setting to inactive but i dont remember what that was. Setting inactive will cause issues later though.
            //transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 50);
            //isactive = false;
        }
        if (isactive == true)
        {
            
            transform.position = new Vector3(transform.position.x, 1, transform.position.z);
            if (canSpawn == true)
            {
                //insert timer to spawn enemies on a loop
                Debug.Log("working");
                string name = this.transform.name;
                if (name == "Lobber_Spawner")
                {
                    Instantiate(Lobber, this.transform.position, Quaternion.identity);
                }
                if (name == "Goblin_Spawner")
                {
                    Instantiate(Goblin, this.transform.position, Quaternion.identity);
                }
                canSpawn = false;
            }
        }   
    }

  
    
}