using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class LevelNumberText : MonoBehaviour
    {
        public Text text;
        public Game game;

        private void Start()
        {
            text.text = "Level " + (game.LevelIndex+1).ToString();
        }

    }
}