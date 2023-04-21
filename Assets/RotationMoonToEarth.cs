using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationMoonToEarth : MonoBehaviour
{
    public Transform rotationPivot; //Dans l'inspector, ce autour de quoi on tourne
    public Vector3 rotationAxis;
    public float rotationSpeed;

    void Update()
    {
        transform.position = new Vector3(transform.position.x * Mathf.Cos(rotationSpeed * Time.deltaTime) - transform.position.z * Mathf.Sin(rotationSpeed * Time.deltaTime),
                                         transform.position.y,
                                         transform.position.x * Mathf.Sin(rotationSpeed * Time.deltaTime) + transform.position.z * Mathf.Cos(rotationSpeed * Time.deltaTime));
    }
}
