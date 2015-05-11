using UnityEngine;
using System.Collections;

public class Master_Control : MonoBehaviour
{

    public GameObject cyclePlayer;
    public GameObject[] players = new GameObject[4];
    public float[] healths = new float[4];
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject Player4;
    public GameObject warriorPrefab;
    public GameObject archerPrefab;
    public GameObject valkyriePrefab;
    public GameObject wizardPrefab;
    public GameObject Player_Spawn;

   
    private int playerCount;
    private Warrior warriorScript;
    private Archer archerScript;
    private Wizard wizardScript;
    private Valkyrie valkyrieScript;

    // Use this for initialization
    void Start()
    {
        //for every player in players array (player added to array from character select menu)
        for (int x = 0; x < players.Length; x++)
        {
            //if there is a player is players array slot # it will spawn that player in as player 1-4
            if (players[x] != null)
            {
                Instantiate(players[x],Player_Spawn.transform.position, Quaternion.identity);

                switch (x + 1)
                {
                    case 1:
                        Player1 = players[0];

                        break;
                    case 2:
                        Player2 = players[2];
                        break;
                    case 3:
                        Player3 = players[3];
                        break;
                    case 4:
                        Player4 = players[4];
                        break;
                    default:
                        Debug.Log("Default Case");
                        break;
                }
          
                //gets the name of the player (warrior, archer etc) and converts to a readable string.
                cyclePlayer = players[x];
                string name = cyclePlayer.transform.name;

                //assigns slots in the health array
                if (name == "Warrior_obj")
                {
                    warriorScript = cyclePlayer.GetComponent<Warrior>();
                    healths[x] = warriorScript.Health;
                }
                if (name == "Archer_obj")
                {
                    archerScript = cyclePlayer.GetComponent<Archer>();
                    healths[x] = archerScript.Health;
                }
                if (name == "Wizard_obj")
                {
                    wizardScript = cyclePlayer.GetComponent<Wizard>();
                    healths[x] = wizardScript.Health;
                }
                if (name == "Valkyrie_obj")
                {
                    valkyrieScript = cyclePlayer.GetComponent<Valkyrie>();
                    healths[x] = valkyrieScript.Health;
                }
            }
        }
    }

    // Update is called once per frame

        void Update()
        {
            //on button press brings up character select.
            //upon selecting character, adds them to player array 
            // instantiate the player

            if(Input.GetKeyDown(KeyCode.A)){
                //  players[1] = 
                // Instantiate(Warrior,transform.position, Quaternion.identity);
        }
 
        for (int x = 0; x < players.Length; x++)
            { 
                if (players[x] != null)
                {
                    switch (x + 1)
                    {
                        case 1:
                            Player1 = players[0];

                            break;
                        case 2:
                            Player2 = players[1];
                            break;
                        case 3:
                            Player3 = players[2];
                            break;
                        case 4:
                            Player4 = players[3];
                            break;
                        default:
                            Debug.Log("Default Case");
                            break;
                    }
                    cyclePlayer = players[x];
                    string name = cyclePlayer.transform.name;

                    //assigns slots in the health array
                    if (name == "Warrior_obj")
                    {
                        warriorScript = cyclePlayer.GetComponent<Warrior>();
                        healths[x] = warriorScript.Health;
                    }
                    if (name == "Archer_obj")
                    {
                        archerScript = cyclePlayer.GetComponent<Archer>();
                        healths[x] = archerScript.Health;
                    }
                    if (name == "Wizard_obj")
                    {
                        wizardScript = cyclePlayer.GetComponent<Wizard>();
                        healths[x] = wizardScript.Health;
                    }
                    if (name == "Valkyrie_obj")
                    {
                        valkyrieScript = cyclePlayer.GetComponent<Valkyrie>();
                        healths[x] = valkyrieScript.Health;
                    }
                }    
            }
        }
}

	