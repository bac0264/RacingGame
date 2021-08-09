using System;
using UnityEngine;

public class CameraFollowVehicle : MonoBehaviour
{
    public GameObject vehicle;

    private Vector3 offset = new Vector3(0, 5, -15);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Smooth the Camera with LateUpdate

    private void LateUpdate()
    {
        transform.position = vehicle.transform.position + offset;
    }
}
