using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    // void Start()
    // {
    //     Debug.Log("First Game!");
    //     // rb.useGravity = false;
    //     rb.AddForce(0,200,500);
    // }
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // We are using FixedUpdate because unity finds it easier when we're modifying physics properties.It is called once per frame.
    void FixedUpdate()
    {
        //Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d")){
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a")){
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
