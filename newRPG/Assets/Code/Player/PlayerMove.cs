using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public GameObject cube;
    public float speed = 5f ;
    public float jump = 4f;
    public Rigidbody playRigidbody;
    private bool bIsJumping = false;

    void Update()
    {
        Move();
        Jump();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        playRigidbody = this.GetComponent<Rigidbody>();
    }

    void Move()
	{
        if (Input.GetKey(KeyCode.W))
        {
            cube.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            cube.transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            cube.transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            cube.transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
    void Jump()
	{
        if (Input.GetButton("Jump"))
        {
            if (float.Parse(string.Format("{0:F1}", transform.position.y)) > jump) return;
            playRigidbody.velocity = new Vector3(playRigidbody.velocity.x, jump, playRigidbody.velocity.z);
        }
        
    }
}