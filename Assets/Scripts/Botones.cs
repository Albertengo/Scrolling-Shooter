using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using enemies;

using UnityEngine.SceneManagement;

namespace interfaz
{
    public class Botones : MonoBehaviour
    {
        public void Restart()
        {
            SceneManager.LoadScene("Game");
            Enemy.enemyKills = 0;
            Spawner.spawneados = 0;
            GameManager.tiempoRestante = 30;
            Time.timeScale = 1f;
        }
        public void Menu()
        {
            SceneManager.LoadScene("Menu");
        }
        public void PlayButton()
        {
            SceneManager.LoadScene("Game");
            Enemy.enemyKills = 0;
            Spawner.spawneados = 0;
            GameManager.tiempoRestante = 0;
            Time.timeScale = 1f;
        }
        public void QuitGame()
        {
            Debug.Log("Saliste.");
            Application.Quit();
        }
    }
}
