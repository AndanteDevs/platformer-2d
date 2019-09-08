using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public Transform playerTransform;
    public CharacterController2D playerMovement;
    public GameObject DeathPanel;
    public float playerYMin;
    public float deathResetDelay = 1;
    public bool onGround = false;
    bool playerHasDied = false;

    // Update is called once per frame
    void FixedUpdate()
    {
        if ( playerTransform.position.y < playerYMin )
        {
            if ( playerHasDied == false )
            {
                Debug.Log("Player death");
                playerHasDied = true;
                playerMovement.enabled = false;
                DeathPanel.SetActive(true);
                Invoke("PlayerDeath", deathResetDelay);
            }
        }
    }

    void PlayerDeath()
    {
        FindObjectOfType<GameManager>().ResetScene();
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if ( collisionInfo.collider.tag == "Ground" )
        {
            onGround = true;
        }
    }

    void OnCollisionExit(Collision collisionInfo)
    {
        if ( collisionInfo.collider.tag == "Ground" )
        {
            onGround = false;
        }
    }
}
