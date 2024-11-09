using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SomSettimgs : MonoBehaviour
{
    [SerializeField] AudioSource musica;

    public void VolumeMusica(float value)
    {
        musica.volume = value;
    }
}
