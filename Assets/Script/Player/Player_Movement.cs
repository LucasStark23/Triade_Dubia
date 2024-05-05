using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float speed = 5f;
    public float turnSpeed;
    public float jumpForce;
    public float runSpeed;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        LockCursor();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        RotatePlayerWithMouse();
        Jump();
        Run();
    }

    void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public struct MovementInfo
    {
        public Vector3 movement; // O movimento calculado
        public bool isMoving;    // Se o jogador está se movendo ou não
    }
    public MovementInfo MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;
        transform.Translate(movement);
        // Atualiza a variável isMoving com base no movimento calculado
        bool isMoving = movement.magnitude > 0.01f;

        // Retorna a estrutura MovementInfo com as informações de movimento
        return new MovementInfo { movement = movement, isMoving = isMoving };

    }

    void RotatePlayerWithMouse()
    {
        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up, mouseX * turnSpeed * Time.deltaTime);
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void Run()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = runSpeed;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 5f;
        }
    }

    void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }

    void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}
