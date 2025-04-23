using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundChecker : MonoBehaviour
{
    public bool isGround = true;

    private void OnTriggerEnter2D(Collider2D other)
    {


        isGround = true;


    }

    private void OnTriggerExit2D(Collider2D other)
    {


        isGround = false;

    }
}
