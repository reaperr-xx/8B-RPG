using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundChecker : MonoBehaviour
{
    public bool isGround;

    public void OnTriggerEnter2D(Collider2D other)
    {


        isGround = true;


    }

     public void OnTriggerExit2D(Collider2D other)
    {


        isGround = false;

    }
}
