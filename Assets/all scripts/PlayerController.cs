using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;
    public groundChecker groundcheck;
    public float jump;

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

        }

    }
}
