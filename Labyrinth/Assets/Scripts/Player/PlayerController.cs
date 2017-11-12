using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{

    [Header("Movement")]
    [SerializeField]
    float moveSpeed, jumpSpeed;

    PlayerMotor motor;

    public bool isPlayer1;

    // Use this for initialization
    void Start()
    {
        motor = gameObject.GetComponent<PlayerMotor>();
    }

    // Update is called once per frame
    void Update()
    {
        float speedX = 0.0f;
        speedX = Input.GetAxisRaw( isPlayer1 ? "J1Horizontal" : "J2Horizontal") * moveSpeed;// * Time.deltaTime;

        motor.MoveBody(speedX);
        //if (Input.GetKeyDown(KeyCode.UpArrow))
        if (Input.GetAxisRaw(isPlayer1 ? "J2Vertical" : "J1Vertical" ) == 1.0f)
        {
            motor.jump(jumpSpeed);
        }
    }
}
