using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{
    public static CameraController instance;
    public Transform target;
    public float SmoothSpeed = 0.125f;
    public Vector3 Offset;
    public bool StopCam = false;

    private void Awake()
    {
        instance = this;
    }

    private void FixedUpdate()
    {
        if(!StopCam)
        {
            Vector3 desiredPosi = target.position + Offset;
            Vector3 smoothPosi = Vector3.Lerp(transform.position, desiredPosi, SmoothSpeed);
            transform.position = smoothPosi;
        }
    }
}
