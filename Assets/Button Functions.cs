using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
    
    public GameObject settingsMenu;
    public static bool musicOn = true;
    public static bool sfxOn = true;
    public static bool screenShakeOn = true;
    public static bool shakeOn = true;
    public static float vibration;
    private void Awake()
    {
        
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Settings()
    {
        settingsMenu.SetActive(true);
    }
    public void CloseSettings()
    {
        settingsMenu.SetActive(false);
    }
    public void MusicOnOff()
    {
        musicOn = !musicOn;
    }
    public void SfxOnOff()
    {
        sfxOn = !sfxOn;
    }
    public void ScreenShakeOnOff()
    {
        screenShakeOn = !screenShakeOn;
    }
    public void ShakeOnOff()
    {
        shakeOn = !shakeOn;
    }
    public void vibrationValue(float value)
    {
        vibration = value;
    }
    
}

