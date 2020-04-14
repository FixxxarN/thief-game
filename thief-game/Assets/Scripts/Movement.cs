using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 5f;
    public bool IsGrounded = false;

    private Rigidbody2D rigidBody; 

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        if(Input.GetKey(KeyCode.A))
        {
            rigidBody.velocity = new Vector2(-movementSpeed, rigidBody.velocity.y);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rigidBody.velocity = new Vector2(movementSpeed, rigidBody.velocity.y);
        }
        else
        {
            rigidBody.velocity = new Vector2(0, rigidBody.velocity.y);
        }
        //Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        //transform.position += movement * Time.deltaTime * movementSpeed;
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 1f), ForceMode2D.Impulse);
        }
    }
}
