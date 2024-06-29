using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Enemy properties")]
    [SerializeField] float speed;
    [SerializeField] int health;
    public GameObject BalaPrefab;
    public Transform FirePoint;

    [Header("Spawn properties")]
    public float Tvivo = 0f;
    public float TMAXvida = 20f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement();
        shoot();
        Destroy();
    }
    void movement()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World); //constantemente se mueve al frente
    }

    void shoot()
    {
        Instantiate(BalaPrefab, FirePoint.position, FirePoint.rotation);

    }

    void Destroy()
    {
        Tvivo += Time.deltaTime; //contador
        if (Tvivo > TMAXvida)
        {
            Destroy(this.gameObject);
        }
    }
}
