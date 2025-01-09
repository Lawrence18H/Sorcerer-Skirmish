using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Cutscene : MonoBehaviour
{
    public GameObject[] lightning;
    public SpriteRenderer wizard;
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("Ground"))
        {
            wizard.enabled = true;
            lightning[0].SetActive(true);
            lightning[1].SetActive(true);
            lightning[2].SetActive(true);
            lightning[3].SetActive(true);
            lightning[4].SetActive(true);
            lightning[5].SetActive(true);
            lightning[6].SetActive(true);
            StartCoroutine(SwitchScene());
        }

    }
    public IEnumerator SwitchScene()
    {
        yield return new WaitForSeconds(3);
        ButtonFunctions.cutsceneWatched = true;
        SaveManager.instance.state.cutsceneWatched = ButtonFunctions.cutsceneWatched;
        SaveManager.instance.Save();
        SceneManager.LoadScene("GameScene");
    }
}
