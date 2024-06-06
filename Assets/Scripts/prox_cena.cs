using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class prox_cena : MonoBehaviour
{

    public void GoHome()
    {
        SceneManager.LoadScene("HomeScene");
    }

    public void Go1()
    {
        SceneManager.LoadScene("Cena1");
    }
    public void Go2()
    {
        SceneManager.LoadScene("Cena2");
    }
    public void Go3()
    {
        SceneManager.LoadScene("Cena3");
    }

    public void GoGame1_()
    {
        SceneManager.LoadScene("JogoPescaVanish_stop");
    }

    public void GoGame1()
    {
        SceneManager.LoadScene("JogoPescaVanish");
    }
        public void GoGame2_()
    {
        SceneManager.LoadScene("JogoLixoFinal_");
    }

    public void GoGame2()
    {
        SceneManager.LoadScene("JogoLixoFinal");
    }
    public void GoGame2Final()
    {
        SceneManager.LoadScene("JogoLixoFinal_1");
    }
    public void GoFinal()
    {
        SceneManager.LoadScene("Cenafinal");
    }
    public void GoCreditos()
    {
        SceneManager.LoadScene("Creditos");
    }
        public void Quit()
    {
        Application.Quit();
    }
}
