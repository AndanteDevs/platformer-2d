using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D controller;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    public float movementSpeed = .85f;

    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * movementSpeed;

        if ( Input.GetButtonDown("Jump") )
        {
            jump = true;
        }

        if ( Input.GetButtonDown("Fire3") )
        {
            crouch = true;
        } else if ( Input.GetButtonUp("Fire3") )
        {
            crouch = false;
        }

    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove, crouch, jump);
        jump = false;
    }
}
