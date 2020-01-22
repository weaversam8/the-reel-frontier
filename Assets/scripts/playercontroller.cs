using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{


    public int numBalls; 
    public float speed; 
    private Rigidbody rb;

    void Start()
    {
        numBalls = 5;
        rb = GetComponent<Rigidbody>();
        if (gameObject.name.Contains("Clone"))
        {
            rb.constraints = RigidbodyConstraints.FreezePosition;
        }
        rb.constraints = RigidbodyConstraints.FreezePositionY;
    }


    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && numBalls > 0 && !gameObject.name.Contains("Clone")) 
        {
            Rigidbody clone;
            clone = Instantiate(rb, transform.position, transform.rotation);
            Vector3 movement = new Vector3(0, 0.0f, 0);

            rb.AddForce(movement * speed);

            clone.velocity = transform.TransformDirection(Vector3.forward);
            numBalls--;
        }
       
    }

    //public class clone
    //{
    //    private Rigidbody rb;
    //    void Start()
    //    {

    //        rb = GetComponent<Rigidbody>();
    //        rb.constraints = RigidbodyConstraints.FreezePositionY;
    //    }
    //}
}
