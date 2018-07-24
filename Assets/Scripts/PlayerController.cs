using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed = 10f;
    public float turnSpeed = 5f;
    Transform mainCamera;
    Quaternion playerRotation;

	// Use this for initialization
	void Start ()
    {
        mainCamera = Camera.main.transform;

    }

    // Update is called once per frame
    void FixedUpdate ()
    {

        // Determine direction
        Vector3 direction = new Vector3(mainCamera.transform.forward.x, mainCamera.transform.forward.y , mainCamera.transform.forward.z).normalized * turnSpeed * Time.deltaTime;

        // Determine Rotation
        Quaternion rotation = Quaternion.Euler(new Vector3(0, -transform.rotation.eulerAngles.y, 0));

        // Move the player
        transform.Translate(rotation * direction);

    }

    
}
