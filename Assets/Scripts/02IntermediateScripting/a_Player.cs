using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a_Player : MonoBehaviour
{
    private int experiencen;
    public int Experience
    {
        get { return experiencen; }
        set { experiencen = value; }
    }

    public int Level
    {
        get {return experiencen/1000 ; }
        set { experiencen = value*1000 ; }
    }

    public int Health{get;set;}
}
