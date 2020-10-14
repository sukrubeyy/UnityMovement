using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMovement : MonoBehaviour
{   [Header("Component")]
    Rigidbody2D rigidBody;
    [Header("Variables")]
    public float speed;
    float vertical, horizontal;
    [Header("About Coordinate System")]
    Vector2 coordinate;
    void Start()
    {
        // We get it rigidbody component here
        rigidBody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        // For Jumping
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // we using force
            rigidBody.AddForce(new Vector2(0,50));
        }
       
        
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        coordinate = new Vector2(horizontal, vertical);
    }

    // we write physics events here
    private void FixedUpdate()
    {
        
        transform.Translate(coordinate * speed*Time.fixedDeltaTime);
    }
}
