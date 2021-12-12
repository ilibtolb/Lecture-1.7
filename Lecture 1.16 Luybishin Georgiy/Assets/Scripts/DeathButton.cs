using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathButton : MonoBehaviour
{
    public Game game;

    public void Restart()
    {
        game.ReloadLevel();
    }
}
