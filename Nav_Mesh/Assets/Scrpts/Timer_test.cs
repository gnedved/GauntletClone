using UnityEngine;
using System.Collections;
using System;
using System.Timers;


public class Timer_test : MonoBehaviour {

   System.Timers.Timer timer = new System.Timers.Timer();
   void Start()
    {
        
        timer.Interval = 5 * 1000;

        timer.Start();

        timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);

    }
    private void timer_Elapsed(object sender, ElapsedEventArgs e)
    {
        Debug.Log("Time Up!");

        timer.Start();

    }

      /*
        // Create a timer with a two second interval.
        aTimer = new System.Timers.Timer(2000);
        // Hook up the Elapsed event for the timer. 
        aTimer.Elapsed += OnTimedEvent;
        aTimer.Enabled = true;
        Debug.Log("YAY!");

        Console.WriteLine("Press the Enter key to exit the program... ");
        Console.ReadLine();
        Console.WriteLine("Terminating the application...");
    }

    private static void OnTimedEvent(object source, ElapsedEventArgs e)
    {
        Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);
    }
    void Start()
    {
        Debug.Log ("This works");
    }
    */
}
