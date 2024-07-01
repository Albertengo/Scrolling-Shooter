using System.Collections;
using UnityEngine;
using interfaz;
using enemies;
using UnityEngine.Device;
using TMPro;

namespace interfaz
{
    public class GameManager : MonoBehaviour
    {
        //script que maneja condiciones de derrota/victoria, un poco de UI & spawns
        #region Variables
        //public GameObject jugador;
        //public GameObject[] enemyPrefabs;
        //public Spawner EnemiesSpawner;

        [Header("UI")]
        public Win_Lose screenW;
        public Win_Lose screenL;
        //public SliderHealth slider;
        public TextMeshProUGUI textoTiempo;
        public TextMeshProUGUI textoKills;
        public static float tiempoRestante;
        #endregion

        #region voids basicos
        void Start()
        {
            Time.timeScale = 1f;
            ComenzarJuego();
        }

        void Update()
        {
            if (Enemy.enemyKills == 6) //si se eliminan 8 enemigos, gameover.
            {
                screenW.ActiveScreen();
                //slider.Desactivar();
            }
            if (tiempoRestante == 0) //si se acaba el tiempo, gameover.
            {
                screenL.ActiveScreen();
                //slider.Desactivar();
            }
            textoTiempo.text = "Seconds left: " + tiempoRestante;
            textoKills.text = "Enemies eliminated: " + Enemy.enemyKills + "/6";
        }
        #endregion

        #region Code
        void ComenzarJuego()
        {
            StartCoroutine(Cronometro(30));
        }
        public IEnumerator Cronometro(float valorCronometro = 30)
        {
            tiempoRestante = valorCronometro;
            while (tiempoRestante > 0)
            {
                yield return new WaitForSeconds(1.0f);
                tiempoRestante--;
            }
        }
        #endregion
    }
}
