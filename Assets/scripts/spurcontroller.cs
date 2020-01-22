using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spurcontroller : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezePosition;
    }

    // Update is called once per frame
    void OnCollision(Collider other)
    {
        rb.constraints = RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationX;
        rb.angularVelocity.Set(10, 10, 10);
    }

}
