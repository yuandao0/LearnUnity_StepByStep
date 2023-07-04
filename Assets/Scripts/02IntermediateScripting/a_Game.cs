using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a_Game : a_Player  //or 'MonoBehaviour'in method2
{
    public a_Player Player1;
    
    void Start()
    {
        Player1.Experience = 5;
        int x = Player1.Experience;

        //method2
        a_Player Player2 = new a_Player();
        Player2.Experience = 5;
        int y = Player2.Experience;
    }

}
