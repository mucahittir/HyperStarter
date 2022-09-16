using GameSpark;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameCoordinator : MonoBehaviour
{
    [SerializeField] PlayerController playerController;
    public void Initialize()
    {
        playerController.Initialize();
    }
    public void StartGame()
    {
        playerController.StartGame();
    }
    public void Reload()
    {
        playerController.Reload();
    }

    public void GameOver()
    {
        playerController.GameOver();
    }

}
