using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{



    void Start()
    {

    }



    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit shot;

            if (Physics.Raycast(transform.position, transform.forward, out shot))
            {

                if (shot.collider.tag == "rocket")
                {
                    Debug.DrawRay(transform.position, transform.forward, Color.green);

                    Destroy(shot.collider.gameObject);
                }
                else
                    Debug.DrawRay(transform.position, transform.forward, Color.red);

            }

        }

    }
}
