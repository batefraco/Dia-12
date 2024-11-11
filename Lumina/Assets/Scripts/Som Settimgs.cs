using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SomSettimgs : MonoBehaviour
{
    [SerializeField] AudioMixer musicBus;

    public void VolumeMusica(float value)
    {
        value = Mathf.Clamp(value, 0.001f, 1f);
        var volume = Mathf.Log(value) * 20;
        musicBus.SetFloat("Volume", volume);
    }
}
