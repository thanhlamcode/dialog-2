using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopCam : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Wall")
        {
            CameraController.instance.StopCam = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Wall")
        {
            CameraController.instance.StopCam = false;
        }
    }
}
