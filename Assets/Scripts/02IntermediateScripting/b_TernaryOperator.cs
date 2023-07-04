using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b_TernaryOperator : MonoBehaviour
{
        void Start()
    {
        int health = 10;
        string message;

        message = health > 0 ? "Pllayer is Alive" : "Player is Dead";
    }

}
