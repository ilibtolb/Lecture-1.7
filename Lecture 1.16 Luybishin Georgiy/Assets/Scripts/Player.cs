using Assets.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float BounceSpeed;
    public Rigidbody Rigidb;
    public Platform CurrentPlatform;
    public Game Game;
    public Sound Sound;
    public ParticleSystem particleDeath;
    public ParticleSystem particleWin;

    public void Bounce()
    {
        Sound.PlayBounce();
        Rigidb.velocity = new Vector3(0, BounceSpeed, 0);
    }

    public void ReachFinish()
    {
        Game.OnPlayerRachedFinish();
        Rigidb.velocity = Vector3.zero;
        particleWin.Play();

    }

    public void Die()
    {
        particleDeath.Play();
        Game.OnPlayerDied();
        Rigidb.velocity = Vector3.zero;


    }
}
