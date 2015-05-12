using UnityEngine;
using System.Collections;

public class Valkyrie : Player
{

    void Start()
    {
        Health = 150.0f;
        characterController = GetComponent<CharacterController>();
    }

}
