using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_Track : MonoBehaviour
{
    public Transform trackedObject;
    public float maxDistance = 10;
    public float moveSpeed = 20;
    public float updateSpeed = 10;
    [Range(0, 10)]
    public float currentDistance = 5;
    private GameObject ahead;
    void Start()
    {
        ahead = new GameObject("ahead");
    }
    void LateUpdate()
    {
        ahead.transform.position = trackedObject.position + trackedObject.forward * (maxDistance * 0.25f);
        currentDistance += moveSpeed * Time.deltaTime;
        currentDistance = Mathf.Clamp(currentDistance, 0, maxDistance);

        transform.position = Vector3.MoveTowards(transform.position,
            trackedObject.position + Vector3.up * currentDistance - trackedObject.forward * (currentDistance + maxDistance * 0.5f),
            updateSpeed * Time.deltaTime); 
        transform.LookAt(ahead.transform);
    }
}
