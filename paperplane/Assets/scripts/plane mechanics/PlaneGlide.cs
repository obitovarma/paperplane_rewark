using UnityEngine;

public class PlaneGlide : MonoBehaviour
{
    public float forwardForce = 50f;
    public float downwardForce = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Apply forward force
        rb.AddForce(transform.forward * forwardForce, ForceMode.Force);

        // Apply downward force
        rb.AddForce(Vector3.down * downwardForce, ForceMode.Force);
    }
}