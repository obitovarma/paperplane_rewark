using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class P_Movement : MonoBehaviour
{

    public Rigidbody rigidbody;
    private Vector3 lastMousePos;
    public float sensitivity = .16f, clampDelta = 42f, bound = 5f;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastMousePos = Input.mousePosition;
        }
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 newPosition = lastMousePos - Input.mousePosition;
            lastMousePos = Input.mousePosition;
            newPosition = new Vector3(newPosition.x, 0, newPosition.y);
            Vector3 moveForce = Vector3.ClampMagnitude(newPosition, clampDelta);
            rigidbody.AddForce((-moveForce * sensitivity - rigidbody.velocity / 5f), ForceMode.VelocityChange);
        }
        rigidbody.velocity.Normalize();
    }
    //Update is called once per frame  
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -bound, bound), transform.position.y, transform.position.z);
    }
}