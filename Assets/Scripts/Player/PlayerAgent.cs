using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAgent : MonoBehaviour
{
    [SerializeField] float speed;
    public void Initialize()
    {
        Debug.Log("Player Initialized");
    }
    public void StartGame()
    {
        transform.DOMoveX(3, 1).SetEase(Ease.InOutCubic)
        .OnComplete(() => GameManager.Instance.GameOver());
    }

    public void Reload()
    {
        setDefaults();
    }

    public void GameOver()
    {
        Debug.Log("Game over");
    }

    private void setDefaults()
    {
        transform.position = new Vector3(0, 0, 0);
    }
}
