using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Timers;

public class Wave_spawner : MonoBehaviour {

    public List<GameObject> spawnerList = new List<GameObject>();
    public Spawner spawnerScript;
    public GameObject spawnerSelect;
    System.Timers.Timer waveTimer = new System.Timers.Timer();
    public int activeSpawns = 0;
    public int totalSpawns;
    public int waveNumber;

    private bool timerActive = true;
    
    
    

    void Start()
    {
       //returns all gameobjects but memory intensive. Also provides resources in the assests folders.
       //foreach(GameObject spawner in Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[]){


        foreach(GameObject spawner in GameObject.FindGameObjectsWithTag("Spawner"))
        {
            spawnerList.Add(spawner);
            Debug.Log("add");
            
        }
        totalSpawns = spawnerList.Count;
        waveTimer.Interval = 60 * 1000;

        waveTimer.Start();

        waveTimer.Elapsed += new ElapsedEventHandler(timer_Elapsed);

    }

    private void timer_Elapsed(object sender, ElapsedEventArgs e)
    {
        timerActive = true;
        waveTimer.Start();
        
        
        

    }

    void Update()
    {
        activeSpawns = spawnerList.Count - totalSpawns + activeSpawns;
        if (activeSpawns < totalSpawns)
        {
            if (timerActive == true)
            {
                
                if (activeSpawns < spawnerList.Count)
                {
                    for (int x = 0; x < 4 + waveNumber; x++)
                    {

                        spawnerSelect = spawnerList[activeSpawns];
                        spawnerScript = spawnerSelect.GetComponent<Spawner>();
                        activeSpawns++;
                        spawnerScript.isactive = true;

                    }
                    waveNumber = waveNumber + 2;
                    timerActive = false;

                }
            }
        }
        else 
        {
            waveTimer.Stop();
        }
         if (spawnerList.Count <= 0)
         { 
            // display win screen
            // move to next level
         }
    }

// on start store all objects with Spawner tag in spawners list
//pick x number of the inactive spawners and set them to active
//set timer to spawn next set of spawners
//after timer goes off perform the above actions again

}