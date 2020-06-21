using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float fowardForce =100f;
    public float sideWaysForce = 100f;
    public Transform player;
    // Start is called before the first frame update

    private void Start()
    {
       
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, fowardForce*Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideWaysForce *Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWaysForce*Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        if (player.position.x <0)
        {
            FindObjectOfType<GameManagerScript>().EndGame();
        }
    }
}
