using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMove : MonoBehaviour
{
    float speed=10f;
    float UpDown;
    Rigidbody rb;

    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(speed,UpDown,rb.velocity.z);
    }

    private void Update()
    {
        var move = GetInputMove();

        if (move.x != 0)
        {
            UpDown = 3f;
        }
        else if (move.y != 0)
        {
            UpDown = -3f;
        }
        else
        {
            UpDown=0f;
        }

        (float x, float y) GetInputMove()
        {
            return (
                Input.GetAxisRaw("Horizontal"),
                Input.GetAxisRaw("Vertical")
            );
        }
    }
    
}
