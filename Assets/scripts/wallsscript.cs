using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallsscript : MonoBehaviour
{
    public AudioSource audioSource; 
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        if (other.collider.name.Contains("playercontroller"))
        {

            audioSource.PlayOneShot(audioSource.clip);
            //audioSource.PlayOneShot(audioSource.clip);

        }

    }
}
