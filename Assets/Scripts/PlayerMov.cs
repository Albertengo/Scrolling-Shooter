using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private int speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();   
    }

    private void Movement()
    {
        
        //float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(0f, 0f, verticalInput); // verticalInput);

        movement.Normalize();

        transform.Translate(movement * Time.deltaTime * speed); //para moverse a los costados segun el player
    }
}
