using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Refer�ncia ao transform do jogador
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void LateUpdate()
    {
        if (target == null)
            return;

        // Obt�m a posi��o desejada da c�mera atr�s do jogador (com o offset) em rela��o � dire��o em que o jogador est� olhando
        Vector3 desiredPosition = target.position - target.forward * offset.z + target.up * offset.y;

        // Interpola suavemente a posi��o atual da c�mera at� a posi��o desejada
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // Faz com que a c�mera sempre olhe para o jogador
        transform.LookAt(target);
    }
}
