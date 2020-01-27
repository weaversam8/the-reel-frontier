using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_delete : MonoBehaviour
{

    // set a value to this in the UI
    public playercontroller playerController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // When a ball enters
    void OnTriggerEnter(Collider other) {
        if (other.name.Contains("playercontroller")) {
            Destroy(other.gameObject);
            playercontroller.numBalls++;
        }
    }
}
