using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPrincipal : MonoBehaviour {

    public Button _btnModoLivre;
    public Button _btnModoNave;
    public Button _btnSairJogo;
    
    public Text _text1;
    public Text _text2;
    public Text _text3;

    //Metodo que chama a cena de modo livre
    public void ModoLivre()
    {
        //impede que o usuario realize mais de um click
        _btnModoLivre.enabled = false;
        //Altera o texto do botão ao clicar
        _text1.text = "Carregando...";
        //Carrega a cena de ModoLivre e fecha as outras cenas
        SceneManager.LoadScene("Free", LoadSceneMode.Single);
    }

    //Metodo que Chama a cena de Navegação
    public void ModoNavegation()
    {
        //impede que o usuario realize mais de um click
        _btnModoNave.enabled = false;
        //Altera o texto do botão ao clicar
        _text2.text = "Carregando...";
        //Carrega a cena de ModoLivre e fecha as outras cenas
        SceneManager.LoadScene("Guide", LoadSceneMode.Single);

    }

    //Metodo que finaliza o Game
    public void SairJogo()
    {
        //impede que o usuario realize mais de um click
        _btnSairJogo.enabled = false;
        //Altera o texto do botão ao clicar
        _text3.text = "Fechando...";
        //Fecha a aplicação
        Application.Quit();
    }
}
