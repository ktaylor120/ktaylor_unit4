using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float speed = 10f;
    void Update()
    {
        float rotateInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, rotateInput * speed * Time.deltaTime);
    }
}
