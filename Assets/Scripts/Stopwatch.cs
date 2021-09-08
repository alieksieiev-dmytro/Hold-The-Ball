using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stopwatch : MonoBehaviour
{
    private float _currentTime;

    private Text stopwatchUI;

    // Start is called before the first frame update
    void Start()
    {
        stopwatchUI = GetComponent<Text>();
        _currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _currentTime += Time.deltaTime;
        TimeSpan time = TimeSpan.FromSeconds(_currentTime);
        stopwatchUI.text = time.ToString(@"mm\:ss\:ff");
    }

    public void ResetTime()
    {
        _currentTime = 0;
        stopwatchUI.text = "00:00:00";
    }
}
