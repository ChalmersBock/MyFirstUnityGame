using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 300f;
    public float jumpHeight = 4f;

    public Rigidbody player;

    private bool isGrounded = true;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            player.AddForce(moveSpeed * Time.deltaTime *Vector3.forward, ForceMode.VelocityChange); 
        }

        if (Input.GetKey("s"))
        {
            player.AddForce(moveSpeed * Time.deltaTime * Vector3.back, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            player.AddForce(moveSpeed * Time.deltaTime * Vector3.left, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))
        {
            player.AddForce(moveSpeed * Time.deltaTime * Vector3.right, ForceMode.VelocityChange);
        }

        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            player.AddForce(jumpHeight * Vector3.up);
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    void onCollsionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }


}
