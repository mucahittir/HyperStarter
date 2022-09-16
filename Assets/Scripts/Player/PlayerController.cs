using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] PlayerAgent player;
    public void Initialize()
    {
        player.Initialize();
    }
    public void StartGame()
    {
        player.StartGame();
    }
    public void Reload()
    {
        player.Reload();
    }
    public void GameOver()
    {
        player.GameOver();
    }
}
