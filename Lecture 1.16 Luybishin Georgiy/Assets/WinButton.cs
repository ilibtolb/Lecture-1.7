using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinButton : MonoBehaviour
{
    public Game game;

    public void Restart()
    {
        game.ReloadLevel();
    }

}
