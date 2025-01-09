using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    //https://www.youtube.com/watch?v=LBs6qOgCDOY
    public static SaveManager instance { set; get; }
    public SaveState state;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        instance = this;
        Load();
    }
    public void Save()
    {
        PlayerPrefs.SetString("save",Helper.Serialize<SaveState>(state));
    }
    public void Load()
    {
        if (PlayerPrefs.HasKey("save"))
        {
            state = Helper.Deserialize<SaveState>(PlayerPrefs.GetString("save"));
        }
        else
        {
            state = new SaveState();
            Save();

        }
    }
}
