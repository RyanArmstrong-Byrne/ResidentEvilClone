using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamChange : MonoBehaviour
{
    [SerializeField] GameObject cameraold, cameranew;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cameranew.SetActive(true);
            cameraold.SetActive(false);
        }

    }
}
