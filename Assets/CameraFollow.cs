using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;          // El coche que la cámara seguirá
    public Vector3 offset = new Vector3(0, 5, -10); // Desplazamiento de la cámara en relación al coche
    public float smoothSpeed = 0.125f; // Velocidad de suavizado

    private void LateUpdate()
    {
        // Calcula la posición deseada de la cámara
        Vector3 desiredPosition = target.position + target.TransformDirection(offset);

        // Interpola suavemente entre la posición actual y la deseada
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Asigna la posición suavizada a la cámara
        transform.position = smoothedPosition;

        // Apunta la cámara hacia el objetivo
        transform.LookAt(target);
    }
}
