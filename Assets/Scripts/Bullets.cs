using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

namespace disparos
{
    public class Bullets : MonoBehaviour
    {
        //este script sirve para manejar la velocidad del disparo y su autodestrucci�n
        #region variables
        public float velocidad = 1f;
        public Rigidbody rbBullet;
        public float tiempo = 3; //el alcance que va a tener la bala antes de desaparecer
        #endregion

        #region funciones basicas
        void Start()
        {
            rbBullet.velocity = transform.right * velocidad;
            Destroy(gameObject, tiempo);
        }

        #endregion

        #region code
        private void OnTriggerEnter(Collider collision)
        {

            if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Player")
            {
                Destroy(gameObject);
            }
        }
            #endregion
    }
}