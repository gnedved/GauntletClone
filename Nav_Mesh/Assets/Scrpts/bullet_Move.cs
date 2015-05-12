using UnityEngine;
using System.Collections;

public class bullet_Move : MonoBehaviour
{

    public float speed = 15.0f;
    public GameObject playerToDamage;
    public Spawner spawnerScript;


    private Warrior warriorScript;
    private Archer archerScript;
    private Wizard wizardScript;
    private Valkyrie valkyrieScript;


    // Use this for initialization
    void Awake()
    {


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }
    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Player")
        {
            playerToDamage = col.gameObject;
            Debug.Log(playerToDamage.name);

            if (col.gameObject.name == "Warrior_obj(Clone)")
            {
                warriorScript = playerToDamage.GetComponent<Warrior>();
                warriorScript.Health = warriorScript.Health - 10;
                Destroy(this.gameObject);
            }
            if (playerToDamage.name == "Archer_obj(Clone)")
            {
                Debug.Log("archer hit");
                archerScript = playerToDamage.GetComponent<Archer>();
                archerScript.Health = archerScript.Health - 10;
                Destroy(this.gameObject);
            }
            if (col.gameObject.name == "Wizard_obj(Clone)")
            {
                wizardScript = playerToDamage.GetComponent<Wizard>();
                wizardScript.Health = wizardScript.Health - 10;
                Destroy(this.gameObject);
            }
            if (col.gameObject.name == "Valkyrie_obj(Clone)")
            {
                valkyrieScript = playerToDamage.GetComponent<Valkyrie>();
                valkyrieScript.Health = valkyrieScript.Health - 10;
                Destroy(this.gameObject);

            }



        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}