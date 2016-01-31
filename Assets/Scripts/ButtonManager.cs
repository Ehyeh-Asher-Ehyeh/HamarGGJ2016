﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {
    public int SceneToLoad;
    public bool b_ShowEndings = false;
    public Canvas MenuCanvas, EndingsCanvas;
    public GameObject MainMenuStuff, OptionsStuff;
    void Start()
    {
        ButtonOptionsBack();
    }
    public void ButtonPlay()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
    public void ButtonOptions()
    {
        MainMenuStuff.SetActive(false);
        OptionsStuff.SetActive(true);
    }
    public void ButtonOptionsBack()
    {
        MainMenuStuff.SetActive(true);
        OptionsStuff.SetActive(false);
    }
    public void ShowEndings()
    {
        b_ShowEndings = !b_ShowEndings;
        if (b_ShowEndings) { MenuCanvas.enabled = !b_ShowEndings; EndingsCanvas.enabled = b_ShowEndings; }
        else { MenuCanvas.enabled = !b_ShowEndings; EndingsCanvas.enabled = b_ShowEndings; }
    }
    public void ButtonExit()
    {
        Application.Quit();
    }
}
