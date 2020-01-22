using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{

    public static int numBalls = 50;
    public bool isClone = false;
    public float speed = 5; 
    public Rigidbody rb;
    public SphereCollider collider;
    public MeshRenderer renderer;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        collider = GetComponent<SphereCollider>();
        renderer = GetComponent<MeshRenderer>();
        if (gameObject.name.Contains("Clone")) isClone = true;
        if (isClone) {
            Vector3 movement = new Vector3(-1500f, 0f, Random.Range(-500f, 500f));
            // rb.velocity = movement;
            rb.AddForce(movement);
        }
    }

    void Update() {
        if (Input.GetKeyUp(KeyCode.Space) && numBalls > 0 && !isClone) 
        {
            GameObject clone;
            clone = Instantiate(gameObject, transform.position, transform.rotation);
            playercontroller cloneController = clone.GetComponent<playercontroller>();

            // clone.velocity = transform.TransformDirection(Vector3.forward);
            numBalls--;
        }
    }

    void FixedUpdate()
    {
        if (isClone) {
            rb.constraints = RigidbodyConstraints.FreezePositionY;
            collider.enabled = true;
            renderer.enabled = true;

            
        } else {
            rb.constraints = RigidbodyConstraints.FreezePosition;
            collider.enabled = false;
            renderer.enabled = false;
        }
    }
}
