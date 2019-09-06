using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    float HorizontalMove;
    float VerticalMove;
    public float movementForce = 25f;
    public float jumpFactor = 10f;
    public Rigidbody playerRigidbody;

    // Update is called once per frame
    void Update()
    {
        HorizontalMove = Input.GetAxisRaw("Horizontal");
        VerticalMove = Input.GetAxisRaw("Jump");
    }

    void FixedUpdate()
    {
        if (FindObjectOfType<PlayerCollision>().onGround != true)
        {
            VerticalMove = 0;
        }

        playerRigidbody.AddForce(0, VerticalMove * movementForce * jumpFactor * Time.deltaTime, HorizontalMove * movementForce * Time.deltaTime, ForceMode.VelocityChange);
    }

}
