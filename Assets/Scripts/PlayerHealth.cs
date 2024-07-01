using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using interfaz;
using UnityEngine.Device;

namespace Player
{
    public class PlayerHealth : MonoBehaviour
    {
        [Header("Lógica")]
        public int VidasMax;
        public static int Vida;
        //Vector3 Spawnposition;

        [Header("UI")]
        public TextMeshProUGUI textoVidas;
        //public Win_Lose screenL;
        //public Win_Lose screenW;


        void Start()
        {
            Vida = VidasMax;
            //textoVidas = GetComponent<TextMeshProUGUI>();
            //Spawnposition = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            VidaTerminada();
            textoVidas.text = "Lives left: " + Vida;
        }

        private void OnTriggerEnter(Collider collision) //para boosters y killzone
        {
            if (collision.gameObject.tag == "Bullet")
            {
                //transform.position = Spawnposition;
                Vida--;
            }
            if (collision.gameObject.CompareTag("Enemy"))
            {
                //SceneManager.LoadScene("Game");
                //screenL.ActiveScreen();
                Time.timeScale = 0f;
            }
        }

        void VidaTerminada()
        {
            if (Vida == 0)
            {
                //screenL.ActiveScreen();
                Debug.Log("Moriste...");
            }
        }
    }
}
