using UnityEngine;
using System.Collections;
using System.Timers;

public class enemy_Attack : MonoBehaviour {

    System.Timers.Timer attackTimer = new System.Timers.Timer();
    public GameObject bulletPrefab;
    public GameObject fireBullet;
    public float angleBetween = 0.0F;

    private bool canFire = false;


	// Use this for initialization
	void Start () {
        attackTimer.Interval = 2 * 1000;

        attackTimer.Start();

        attackTimer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
	}
	
	// Update is called once per frame
	void Update () {
        if (canFire == true)
        {
            GameObject fireBullet = (GameObject)Instantiate(bulletPrefab, this.transform.position, this.transform.rotation);
            Physics.IgnoreCollision(fireBullet.GetComponent<Collider>(), GetComponent<Collider>());
            Debug.Log("fire");
            canFire = false;
        }
	}

    private void timer_Elapsed(object sender, ElapsedEventArgs e)
    {
        canFire = true; 
        //Instantiate(Lobber, this.transform.position, Quaternion.identity);
        attackTimer.Start();



    }
}
