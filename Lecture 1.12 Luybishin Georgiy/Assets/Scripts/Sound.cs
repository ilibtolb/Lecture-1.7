using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource _audio;
    public AudioClip Break;
    public AudioClip Bounce;
    public float Vol;

    private void Update()
    {
        _audio.volume = Vol;
    }

    public void PlayBackround()
    {
        _audio.Play();
    }

    public void PlayBreak()
    {
        _audio.PlayOneShot(Break);
    }
    public void PlayBounce()
    {
        _audio.PlayOneShot(Bounce);
    }
}
