using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Platform : MonoBehaviour
    {
 
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Player player))
            {
                player.CurrentPlatform = this;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.TryGetComponent(out Player player))
            {
                player.Sound.PlayBreak();
            }
            gameObject.SetActive(false);

        }

    }
}