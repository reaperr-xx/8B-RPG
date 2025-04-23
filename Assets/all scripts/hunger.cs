using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hunger : MonoBehaviour
{
    public float hungeer = 100f;
    public float timer = 0f;
    public float timer1 = 0f;
    public float hungerSpeed = 10f;
    void Start()
    {
        timer += Time.deltaTime;
        if (timer == hungerSpeed) 
        {
            hungeer --;
            timer = 0f;
        }
            
    }


    void Update()
    {
         timer += Time.deltaTime;
        if (timer >= hungerSpeed) 
        {
            hungeer --;
            timer = 0f;
        }
        
        if (hungerSpeed != 10) 
        {
            timer1 += Time.deltaTime;

            if (timer1 >= 3) 
            {
                timer1 = 0f; 
                hungerSpeed = 10f;
            }
        }

        Debug.Log(hungeer);
    }
}
