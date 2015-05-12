using UnityEngine;
using System.Collections;

public class Warrior : Player
{


    void Start()
    {
        Health = 200.0f;
        characterController = GetComponent<CharacterController>();
    }

}
