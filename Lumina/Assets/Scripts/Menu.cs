using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    [SerializeField] GameObject Indice;
    [SerializeField] GameObject Options;
    public void Jogar()
    {
        SceneManager.LoadScene("Escolha");
        PlayerPrefs.DeleteKey("HasSave");
    }

    public void Continuar()
    {
        SceneManager.LoadScene("Fase1");
    }
    public void Opções()
    {
        Indice.SetActive(false);
        Options.SetActive(true);
    }
    public void Sair()
    {
        Options.SetActive(false);
        Indice.SetActive(true);
    }
    public void Fechar()
    {
        Application.Quit();
    }
}
