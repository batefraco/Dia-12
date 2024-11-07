using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gerenciar : MonoBehaviour
{
    [SerializeField] GameObject Player1;

    public void Lucca()
    {
        SceneManager.LoadScene("Fase1");
    }
}
