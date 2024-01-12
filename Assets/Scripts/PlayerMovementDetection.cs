using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementDetection : MonoBehaviour
{
    private Vector3 previousPosition;
    private float movementThreshold = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        previousPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = transform.position - previousPosition;
        previousPosition = transform.position;
        bool isMoving = movement.magnitude > movementThreshold;
        if(isMoving)
        {
            Debug.Log ("Player Move");

        }
        else
        {
            Debug.Log("Player doesn't Move");
        }
    }
}
