using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Player : MonoBehaviour
{


    public float speed = 10.0F; 
    public float rotationSpeed = 200.0F; 

    void Update()
    {
        transform.Translate(0, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime, 0);

    }
}