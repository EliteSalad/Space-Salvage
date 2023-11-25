using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thruster : MonoBehaviour
{
    private Rigidbody spaceshipRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        spaceshipRigidbody = transform.parent.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            spaceshipRigidbody.AddForceAtPosition(transform.right, transform.position, ForceMode.Force);
        }
    }
}
