using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    public float Health = 100.0f;
    public float speed = 8f;
    protected CharacterController characterController;
    public int playerNumber;

	void Start ()
    {
        characterController = GetComponent<CharacterController>();
	}
	

	void Update ()
    {
        //string playerString = playerNumber.ToString();

        Vector3 moveVector = Vector3.zero;
        moveVector.x = Input.GetAxis("LSX" + playerNumber) * speed;
        moveVector.z = Input.GetAxis("LSY" + playerNumber) * speed;
        
        float lt = Input.GetAxis("LT" + playerNumber);
        if (lt != 0f)
        {
            print("LT: " + lt);
        }

        float rt = Input.GetAxis("RT" + playerNumber);
        if (rt != 0f)
        {
            print("RT: " + rt);
        }

        float rsx = Input.GetAxis("RSX" + playerNumber);
        float rsy = Input.GetAxis("RSY" + playerNumber);

        Vector3 temp = transform.position;
        temp.x += rsx;
        temp.z += rsy;
        transform.LookAt(temp);

        //print("LT: " Input.GetAxis("LT"));

        if (Input.GetButtonDown("A" + playerNumber))
        {
            print("A");
        }

        if (Input.GetButtonDown("B" + playerNumber))
        {
            print("B");
        }

        if (Input.GetButtonDown("X" + playerNumber))
        {
            print("X");
        }

        if (Input.GetButtonDown("Y" + playerNumber))
        {
            print("Y");
        }

        if (Input.GetButtonDown("LB" + playerNumber))
        {
            print("LB");
        }

        if (Input.GetButtonDown("RB" + playerNumber))
        {
            print("RB");
        }

        characterController.Move(moveVector * Time.deltaTime);
	}
}
