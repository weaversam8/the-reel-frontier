using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBalls : MonoBehaviour
{
    // set a value to this in the UI
    public playercontroller playerController;
    public bool deleteOnScore = true;

    // number of balls awarded (set in UI)
    public int numBalls = 0;

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
            if (deleteOnScore) Destroy(other.gameObject);
            playercontroller.numBalls += numBalls;
        }
    }
}
