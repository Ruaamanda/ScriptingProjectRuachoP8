using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //I want to get the x locattion of a game object and show it on the console
        Debug.Log(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        //I want to know when a game object's y position is lower than 5.
        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit ground!");
        }
    }
}
