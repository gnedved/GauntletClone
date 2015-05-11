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

    private bool timerActive = false;
    
    
    

    void Start()
    {
       //returns all gameobjects but memory intensive. Also provides resources in the assests folders.
       //foreach(GameObject spawner in Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[]){


        foreach(GameObject spawner in GameObject.FindGameObjectsWithTag("Spawner")){
                spawnerList.Add(spawner);
                Debug.Log("add");
            
        }
        totalSpawns = spawnerList.Count;
        waveTimer.Interval = 10 * 1000;

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
         if (timerActive == true)
         {
             if (activeSpawns < spawnerList.Count)
             {
                 for (int x = 0; x < 3; x++)
                 {
                 
                    spawnerSelect = spawnerList[activeSpawns];
                    Debug.Log(spawnerSelect);
                    spawnerScript = spawnerSelect.GetComponent<Spawner>();
                    activeSpawns++;
                    spawnerScript.isactive = true;
                    
                 }
                 timerActive = false;
             }
         }
    }

// on start store all objects with Spawner tag in spawners list
//pick x number of the inactive spawners and set them to active
//set timer to spawn next set of spawners
//after timer goes off perform the above actions again

}