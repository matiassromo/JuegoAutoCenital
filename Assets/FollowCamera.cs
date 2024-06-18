using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target; // El objeto al que la cámara seguirá (en este caso, el carro)
    public Vector3 offset;   // Desplazamiento de la cámara desde el objetivo

    void LateUpdate()
    {
        if (target != null)
        {
            // La posición de la cámara es la posición del objetivo más el desplazamiento
            transform.position = target.position + offset;
        }
    }
}
