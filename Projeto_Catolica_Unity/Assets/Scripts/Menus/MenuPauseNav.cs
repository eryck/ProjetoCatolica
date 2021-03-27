using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPauseNav : MonoBehaviour {

    private bool _estadopause = false;
    //Local para associar o objeto de cavas do meu pause
    public GameObject _canvasPause;
    //Local para associar o objeto do botão pause
    public GameObject _btnPause;
  

    private void Update()
    {
        //Pausa o game no meu pausa
        if (_estadopause)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }

    }

    //Ativa o menu pause
    public void ModoPause()
    {
        _estadopause = true;
        _canvasPause.SetActive(_estadopause);
        _btnPause.SetActive(false);

    }

    //Retorna a aplicação
    public void Retornar()
    {
        _estadopause = false;
        _canvasPause.SetActive(_estadopause);
        _btnPause.SetActive(true);
    }

    //Metodo que Chama a cena de Navegação
    public void ModoLivre()
    {
        //Carrega a cena de ModoLivre e fecha as outras cenas
        SceneManager.LoadScene("Free", LoadSceneMode.Single);
    }

    //Metodo que Chama a cena de Navegação
    public void MenuPrincipal()
    {
        //Carrega a cena de ModoLivre e fecha as outras cenas
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    //Metodo que finaliza o Game
    public void SairJogo()
    {
        //Fecha a aplicação
        Application.Quit();
    }
}
