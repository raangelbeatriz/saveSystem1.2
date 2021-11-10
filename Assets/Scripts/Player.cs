using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player player;
    public Rigidbody2D theRB;
    public float moveSpeed, jumpPower;

    
    private void Awake()
    {
        player = this;
    }


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, theRB.velocity.y);

        Jump();
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            theRB.velocity = new Vector2(theRB.velocity.x, jumpPower);
        }
    }
}