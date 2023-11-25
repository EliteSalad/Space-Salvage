using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipConstructor_Edit : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.position = Mouse3D.GetMouseWorldPosition();
    }
}
