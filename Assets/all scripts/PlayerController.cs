using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;
    public groundChecker groundcheck;
    public float jump;
    public hunger hungerLocal;
    public bool isJumping = false;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        

    }

    // Update is called once per frame
    void Update()
    {
        groundcheck.GetComponent<groundChecker>();
        groundChecker grch = groundcheck.GetComponent<groundChecker>();

        Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
        transform.position = transform.position + playerInput.normalized * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && grch.isGround == true)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            hungerLocal.GetComponent<hunger>();
            hunger hungerVar = hungerLocal.GetComponent<hunger>();
            hungerVar.hungerSpeed = 5f;
            isJumping = true;
        }

        if (playerInput.x != 0)
        {
            hunger hungerVar = hungerLocal.GetComponent<hunger>();
            hungerVar.hungerSpeed = 7f;
        }


        if (playerInput.x != 0 && isJumping == true)
        {
            hunger hungerVar = hungerLocal.GetComponent<hunger>();
            hungerVar.hungerSpeed = 4f;
            isJumping = false;
        }


    }
}
