using Assets.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.Scripts
{
    public class Platform : MonoBehaviour
    {
        public ParticleSystem particles;
        public GameObject Sectors;


        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Player player))
            {
                player.CurrentPlatform = this;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            particles.Play();
            if (other.TryGetComponent(out Player player))
            {
                player.Sound.PlayBreak();
            }
            Sectors.SetActive(false);
        }
    }
}