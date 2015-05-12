using UnityEngine;
using System.Collections;
using System.Timers;

public class enemy_Attack : MonoBehaviour {

    System.Timers.Timer attackTimer = new System.Timers.Timer();
    public GameObject bulletPrefab;
    public GameObject fireBullet;
    public float angleBetween = 0.0F;
    public GameObject Targeter;

    private bool canFire = false;
    private target_Player Target_Player;
    private RaycastHit Hit;

	// Use this for initialization
	void Start () {

        Targeter = this.gameObject;
        attackTimer.Interval = 2 * 1000;

        attackTimer.Start();

        attackTimer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
	}
	
	// Update is called once per frame
    void Update()
    {
        if (canFire == true)
        {
             //Raycast to target
            //Target_Player = Targeter.GetComponent<target_Player>();
            //Debug.Log (Physics.Linecast(transform.position, Target_Player.target.position));
            //if (!Physics.Linecast(transform.position, Target_Player.target.position))

            //Raycast forward
            // Vector3 fwd = transform.TransformDirection(Vector3.forward);
            //if (Physics.Raycast(transform.position, fwd, 10) == true)
            
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
