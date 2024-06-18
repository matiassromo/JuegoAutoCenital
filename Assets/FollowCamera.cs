using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target; // El objeto al que la c�mara seguir� (en este caso, el carro)
    public Vector3 offset;   // Desplazamiento de la c�mara desde el objetivo

    void LateUpdate()
    {
        if (target != null)
        {
            // La posici�n de la c�mara es la posici�n del objetivo m�s el desplazamiento
            transform.position = target.position + offset;
        }
    }
}
