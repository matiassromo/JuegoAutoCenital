using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    public float moveSpeed = 40f;
    public float turnSpeed = 80f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

        float currentSpeed = moveSpeed;

        // Duplica la velocidad si la tecla Espacio está presionada
        if (Input.GetKey(KeyCode.Space))
        {
            currentSpeed *= 2;
        }
        // Movimiento hacia adelante
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 forwardMovement = transform.forward * currentSpeed;
            rb.velocity = forwardMovement;
        }

        // Movimiento hacia atrás
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 backwardMovement = -transform.forward * currentSpeed;
            rb.velocity = backwardMovement;
        }

        // Giro a la izquierda
        if (Input.GetKey(KeyCode.A))
        {
            float turn = -turnSpeed * Time.fixedDeltaTime;
            Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
            rb.MoveRotation(rb.rotation * turnRotation);
        }

        // Giro a la derecha
        if (Input.GetKey(KeyCode.D))
        {
            float turn = turnSpeed * Time.fixedDeltaTime;
            Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
            rb.MoveRotation(rb.rotation * turnRotation);
        }


    }
}