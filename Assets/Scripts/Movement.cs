using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

   public float speed;
public Joystick joystick;

    private void Update()
    {
        float xMovement = joystick.Horizontal;
        float zMovement = joystick.Vertical;

        transform.position += new Vector3(xMovement, 0f, zMovement) * speed * Time.deltaTime; //Hareket Kodu
    }
}
