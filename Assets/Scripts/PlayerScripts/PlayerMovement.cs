using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 7f;
    
    public float jumpHeight = 4f;
    public float turnRate = 5f;

    public Rigidbody playerRigid;
    public Transform playerTrans;

    private bool isGrounded = true;


    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * turnRate * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);

        float vertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, 0, vertical);
    }

  
    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            playerRigid.AddForce(jumpHeight * Vector3.up);
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
