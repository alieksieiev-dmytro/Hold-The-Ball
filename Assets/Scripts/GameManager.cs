using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region Singleton

    public static GameManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Game Manager found");
            return;
        }

        instance = this;
    }

    #endregion

    [SerializeField] private GameObject fadeScreen;
    [SerializeField] private GameObject restartMenu;
    [SerializeField] private GameObject startMenu;

    [SerializeField] private Stopwatch stopWatch;

    [SerializeField] private Ball ball;
    [SerializeField] private PlayerController platform;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        fadeScreen.SetActive(true);
        startMenu.SetActive(true);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        fadeScreen.SetActive(true);
        restartMenu.SetActive(true);
    }

    public void Restart()
    {
        fadeScreen.SetActive(false);
        restartMenu.SetActive(false);

        ball.ToStartPosition();
        platform.ToStartRotation();
        stopWatch.ResetTime();

        Time.timeScale = 1;
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        fadeScreen.SetActive(false);
        startMenu.SetActive(false);
    }
}
