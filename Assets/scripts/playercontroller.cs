using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playercontroller : MonoBehaviour
{

    public static int numBalls = 5;
    public bool isClone = false;
    public float speed = 5; 
    public Rigidbody rb;
    public SphereCollider collider;
    public MeshRenderer renderer;
    public Text textbox;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        collider = GetComponent<SphereCollider>();
        renderer = GetComponent<MeshRenderer>();
        
        if (gameObject.name.Contains("Clone")) isClone = true;
        if (isClone) {
            Vector3 movement = new Vector3(Random.Range(-250f, 250f), -500f, 0);
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

        textbox.text = ("You have " + numBalls + " balls left!");
    }

    void FixedUpdate()
    {
        if (isClone) {
            rb.constraints = RigidbodyConstraints.FreezePositionZ;
            collider.enabled = true;
            renderer.enabled = true;

            
        } else {
            rb.constraints = RigidbodyConstraints.FreezePosition;
            collider.enabled = false;
            renderer.enabled = false;
        }
    }
}
