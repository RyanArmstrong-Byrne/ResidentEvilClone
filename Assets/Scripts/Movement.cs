using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed, rotateSpeed;
    float movement, rotation;

    private void Update()
    {
        movement = Input.GetAxis("Vertical")*moveSpeed*Time.deltaTime;
        rotation = Input.GetAxis("Horizontal") *rotateSpeed*Time.deltaTime;
    }

    private void LateUpdate()
    {
        transform.Translate(Vector3.forward * movement);
        transform.Rotate(0f, rotation, 0f);
    }
}
