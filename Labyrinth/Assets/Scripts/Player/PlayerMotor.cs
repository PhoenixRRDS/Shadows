using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMotor : MonoBehaviour
{

    Rigidbody rb;
    float velocity;

    [SerializeField]
    float bonusGravity;
    [SerializeField]
    bool isGrounded;

    [SerializeField]
    LayerMask layers;


    // Use this for initialization
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(velocity, rb.velocity.y);
        
        isGrounded = Physics.Raycast(transform.position, -Vector3.up, 0.5f, layers);

        if (!isGrounded)
        {
            Vector3 vel = rb.velocity;
            vel.y -= bonusGravity * Time.deltaTime;
            rb.velocity = vel;
        }
    }

    public void MoveBody(float _velocity)
    {
        velocity = _velocity;
    }

    public void jump(float jumpForce)
    {
        if (isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
