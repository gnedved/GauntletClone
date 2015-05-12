using UnityEngine;
using System.Collections;

public class Wizard : Player
{

	void Start ()
    {
        Health = 90.0f;
        characterController = GetComponent<CharacterController>();
	}

}
