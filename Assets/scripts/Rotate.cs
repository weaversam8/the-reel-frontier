using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public int rotateDirection = 1;
    public float delta = -0.1f;
    public float leftBound = -0.2f;
    public float rightBound = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0f, 0f, delta * rotateDirection, Space.Self);
        Debug.Log(gameObject.transform.rotation.z);
        if (gameObject.transform.rotation.z > rightBound) rotateDirection = 1;
        if (gameObject.transform.rotation.z < leftBound) rotateDirection = -1;
    }
}
