using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Drag the player object onto this variable in the Inspector
    public Vector3 offset = new Vector3(0, 2, -5); // Customize the camera offset here

    void LateUpdate()
    {
        transform.position = player.position + offset;
        transform.LookAt(player.position);
    }
}