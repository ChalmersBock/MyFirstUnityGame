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


    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * turnRate * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);

        float vertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, 0, vertical);

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            playerRigid.AddForce(jumpHeight * Vector3.up);
        }
    }

    private bool IsGrounded()
    {
        float DisstanceToTheGround = GetComponent<Collider>().bounds.extents.y;

        return Physics.Raycast(transform.position, Vector3.down, DisstanceToTheGround + 0.1f); ;
    }

}
