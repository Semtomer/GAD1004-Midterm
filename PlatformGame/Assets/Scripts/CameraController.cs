using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Third person camera codes

    public Transform lookAt;
    Transform camTransform;

    Camera cam;

    public float distanceZ = 3;
    public float distanceY = 3;
    float currentX = 0;
    float currentY = 0;
    float sensivityX = 4;
    float sensivityY = 1;

    public float yRotationMin = -50;
    public float yRotationMax = 50;

    void Start()
    {
        camTransform = transform;
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        currentX += Input.GetAxis("Mouse X") * sensivityX;
        currentY += Input.GetAxis("Mouse Y") * sensivityY;

        currentY = Mathf.Clamp(currentY, yRotationMin, yRotationMax);
    }

    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, distanceY, distanceZ);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(new Vector3(lookAt.position.x, lookAt.position.y +1, lookAt.position.z));
    }
}
