using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;          // El coche que la c�mara seguir�
    public Vector3 offset = new Vector3(0, 5, -10); // Desplazamiento de la c�mara en relaci�n al coche
    public float smoothSpeed = 0.125f; // Velocidad de suavizado

    private void LateUpdate()
    {
        // Calcula la posici�n deseada de la c�mara
        Vector3 desiredPosition = target.position + target.TransformDirection(offset);

        // Interpola suavemente entre la posici�n actual y la deseada
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Asigna la posici�n suavizada a la c�mara
        transform.position = smoothedPosition;

        // Apunta la c�mara hacia el objetivo
        transform.LookAt(target);
    }
}
