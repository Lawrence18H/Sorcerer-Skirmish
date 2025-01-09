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
        settingsMenu.SetActive(true);
        HapticFeedback.LightFeedback();
    }
    public void CloseSettings()
    {
        settingsMenu.SetActive(false);
        HapticFeedback.LightFeedback();
    }
    public void MusicOnOff()
    {
        musicOn = !musicOn;
        HapticFeedback.LightFeedback();
    }
    public void SfxOnOff()
    {
        sfxOn = !sfxOn;
        HapticFeedback.LightFeedback();
    }
    public void ScreenShakeOnOff()
    {
        screenShakeOn = !screenShakeOn;
        HapticFeedback.LightFeedback();
    }
    public void ShakeOnOff()
    {
        shakeOn = !shakeOn;
        HapticFeedback.LightFeedback();
    }
    public void vibrationValue(float value)
    {
        vibration = value;
    }
   
}

