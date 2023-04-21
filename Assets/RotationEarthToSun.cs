using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class RotationEarthToSun : MonoBehaviour
{
    public Transform rotationPivot; //Dans l'inspector, ce autour de quoi on tourne
    public Vector3 rotationAxis;
    public float rotationSpeed;


    private void Update()
    {
        //D'abord on fait la rotation sur soi meme autour d'un autre axe
        // q = (sin * th�ta/2) * vector.x/y/z + cos * (th�ta / 2)

        transform.rotation *= new Quaternion(Mathf.Sin(rotationSpeed * Time.deltaTime / 2) * rotationAxis.x,
                                             Mathf.Sin(rotationSpeed * Time.deltaTime / 2) * rotationAxis.y,
                                             Mathf.Sin(rotationSpeed * Time.deltaTime / 2) * rotationAxis.z,
                                             Mathf.Cos(rotationSpeed * Time.deltaTime / 2));
        
        //Tourner autour d'un objet 
        // vector' = (vx cos th�ta - vy sin th�ta) , (vx sin th�ta + vy cos th�ta) , vz (si tourne sur l'axe z)

        transform.position = new Vector3(transform.position.x * Mathf.Cos(rotationSpeed * Time.deltaTime) - transform.position.z * Mathf.Sin(rotationSpeed * Time.deltaTime),
                                         transform.position.y,
                                         transform.position.x * Mathf.Sin(rotationSpeed * Time.deltaTime) + transform.position.z * Mathf.Cos(rotationSpeed * Time.deltaTime));
                                         
    }
}
