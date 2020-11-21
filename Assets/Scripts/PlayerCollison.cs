using UnityEngine;

public class PlayerCollison : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo) {

        if(collisionInfo.collider.tag == "Obstacle"){
            // Debug.Log(collisionInfo.collider.name);
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
