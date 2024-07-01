using disparos;
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

    [Header("Shooting properties")]
    public float shootCooldown = 2f; // Time between shots
    private float shootTimer;

    [Header("Spawn properties")]
    public float Tvivo = 0f;
    public float TMAXvida = 20f;
    void Start()
    {
        shootTimer = shootCooldown;
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
        transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World); //constantemente se mueve al frente
    }

    void shoot()
    {
        shootTimer -= Time.deltaTime; //Disminuir timer

        if (shootTimer <= 0f)
        {
            Instantiate(BalaPrefab, FirePoint.position, FirePoint.rotation);
            shootTimer = shootCooldown; // Resetear el timer
        }
    }

    private void OnTriggerEnter(Collider collision) //para boosters y killzone
    {
        if (collision.gameObject.tag == "Bullet")
        {
            //transform.position = Spawnposition;
            health--;
            VidaTerminada();
            Debug.Log("Vida enemigo: " + health);
        }
    }

    void Destroy()
    {
        Tvivo += Time.deltaTime; //contador
        if (Tvivo > TMAXvida)
        {
            Destroy(this.gameObject);
        }
    }
    void VidaTerminada()
    {
        if (health == 0)
        {
            Destroy(this.gameObject);
            Debug.Log("Enemigo eliminado.");
        }
    }
}
