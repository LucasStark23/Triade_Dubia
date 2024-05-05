using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Referência ao transform do jogador
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void LateUpdate()
    {
        if (target == null)
            return;

        // Obtém a posição desejada da câmera atrás do jogador (com o offset) em relação à direção em que o jogador está olhando
        Vector3 desiredPosition = target.position - target.forward * offset.z + target.up * offset.y;

        // Interpola suavemente a posição atual da câmera até a posição desejada
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // Faz com que a câmera sempre olhe para o jogador
        transform.LookAt(target);
    }
}
