using UnityEngine;
using System.Collections;

public class bullet_Move : MonoBehaviour {
    
    public float speed = 15.0f;
    public GameObject playerToDamage;
    public Spawner spawnerScript;


    private Warrior warriorScript;
    private Archer archerScript;
    private Wizard wizardScript;
    private Valkyrie valkyrieScript;


	// Use this for initialization
	void Awake () {
        

	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
	}
    void OnCollisionEnter(Collision col)
    {
        /*
        if (col.gameObject.tag == "player")
        {
            playerToDamage = col.gameObject;
            if (name == "Warrior_obj")
            {
                warriorScript = playerToDamage.GetComponent<Warrior>();
                playerToDamage.warriorScript.Health ++;
            }
            if (name == "Archer_obj")
            {
                archerScript = playerToDamage.GetComponent<Archer>();
                healths[x] = archerScript.Health;
            }
            if (name == "Wizard_obj")
            {
                wizardScript = playerToDamage.GetComponent<Wizard>();
                healths[x] = wizardScript.Health;
            }
            if (name == "Valkyrie_obj")
            {
                valkyrieScript = playerToDamage.GetComponent<Valkyrie>();
                healths[x] = valkyrieScript.Health;
            }
         
        }
         */
        if ((col.gameObject.tag != "enemy") || (col.gameObject.tag != "Spawner"))
            Debug.Log("Destroy");
        Destroy(this.gameObject);
    }
}