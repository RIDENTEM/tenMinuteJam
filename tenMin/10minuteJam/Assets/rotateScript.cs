using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateScript : MonoBehaviour
{


    [SerializeField] GameObject player;
    float speed = 600.0f;
    
    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, speed * Time.deltaTime);

    }
}
