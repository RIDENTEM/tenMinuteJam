using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour {
    float pitch = 0.0f;
    float yaw = 0.0f;

    float pSpeed = 2.0f;
    float ySpeed = 2.0f;

	void Start () {
        Cursor.lockState = CursorLockMode.Locked;
	}
	 
	void Update () {

        yaw += ySpeed * Input.GetAxis("Mouse X");
        pitch -= pSpeed * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
	}
}
