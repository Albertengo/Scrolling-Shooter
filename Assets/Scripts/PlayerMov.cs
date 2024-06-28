using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private int speed;
    bool isActive;
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
        if (isActive == false) //mientras estes en el piso, se podra saltar, es para evitar volar
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector3.up * speed);
                isActive = true;
            }
            if (Input.GetKeyUp(KeyCode.Space))
                isActive = false;
        }
            //Debug.Log("Estas en el piso");

        //float horizontalInput = Input.GetAxis("Horizontal");
        //float verticalInput = Input.GetAxis("Vertical");
        //Vector3 movement = new Vector3(horizontalInput, 0f, 0f); // verticalInput);

        //movement.Normalize();

        //transform.Translate(movement * Time.deltaTime * speed); //para moverse a los cpstados segun el player
        //transform.Translate(Vector3.forward * Time.deltaTime * speedworld, Space.World); //constantemente se mueve al frente
    }
}
