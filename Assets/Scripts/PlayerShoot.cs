using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject BalaPrefab;
    public Transform FirePoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            disparar();
        }
    }

    void disparar()
    {
        Instantiate(BalaPrefab, FirePoint.position, FirePoint.rotation);
    }
}
