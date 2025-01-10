using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CandyCoded.HapticFeedback;
public class ButtonFunctions : MonoBehaviour
{
    
    public GameObject settingsMenu;
    public static bool musicOn = true;
    public static bool sfxOn = true;
    public static bool screenShakeOn = true;
    public static bool shakeOn = true;
    public static float vibration;
    public static bool cutsceneWatched;
    private void Awake()
    {
        cutsceneWatched = SaveManager.instance.state.cutsceneWatched;
        SaveManager.instance.Load();
        musicOn = SaveManager.instance.state.musicOn;
        SaveManager.instance.Load();
        sfxOn = SaveManager.instance.state.sfxOn;
        SaveManager.instance.Load();
        screenShakeOn = SaveManager.instance.state.screenShakeOn;
        SaveManager.instance.Load();
        shakeOn = SaveManager.instance.state.shakeOn;
        SaveManager.instance.Load();
        vibration = SaveManager.instance.state.vibration;
        SaveManager.instance.Load();
    }
    public void PlayGame()
    {
        if (!cutsceneWatched)
        {
            SceneManager.LoadScene("CutScene");
        }
        else if (cutsceneWatched)
        {
            SceneManager.LoadScene("GameScene");
        }
        HapticFeedback.LightFeedback();
    }
    public void Settings()
    {
        Time.timeScale = 0;
        settingsMenu.SetActive(true);
        HapticFeedback.LightFeedback();
    }
    public void CloseSettings()
    {
        Time.timeScale = 1;
        settingsMenu.SetActive(false);
        HapticFeedback.LightFeedback();
    }
    public void MusicOnOff()
    {
        musicOn = !musicOn;
        SaveManager.instance.state.musicOn = musicOn;
        SaveManager.instance.Save();
        HapticFeedback.LightFeedback();
    }
    public void SfxOnOff()
    {
        sfxOn = !sfxOn;
        SaveManager.instance.state.sfxOn = sfxOn;
        SaveManager.instance.Save();
        HapticFeedback.LightFeedback();
    }
    public void ScreenShakeOnOff()
    {
        screenShakeOn = !screenShakeOn;
        SaveManager.instance.state.screenShakeOn = screenShakeOn;
        SaveManager.instance.Save();
        HapticFeedback.LightFeedback();
    }
    public void ShakeOnOff()
    {
        shakeOn = !shakeOn;
        SaveManager.instance.state.shakeOn = shakeOn;
        SaveManager.instance.Save();
        HapticFeedback.LightFeedback();
    }
    public void vibrationValue(float value)
    {
        SaveManager.instance.state.vibration = vibration;
        SaveManager.instance.Save();
        vibration = value;
    }
   
}

