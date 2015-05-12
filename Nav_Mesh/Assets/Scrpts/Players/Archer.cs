using UnityEngine;
using System.Collections;

public class Archer: Player
{

	void Start ()
    {
        speed = 10f;
        characterController = GetComponent<CharacterController>();
	}

}
