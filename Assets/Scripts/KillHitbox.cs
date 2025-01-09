using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CandyCoded.HapticFeedback;
public class KillHitbox : MonoBehaviour
{
    Player pScript;
    CinemachineFunctions cScript;
    ButtonFunctions bScript;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        pScript = FindObjectOfType<Player>();
        cScript = FindObjectOfType<CinemachineFunctions>();
        bScript = FindObjectOfType<ButtonFunctions>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("hit");
            float pitchlevel = (Random.Range(8, 14) * 0.1f);
            audioSource.pitch = pitchlevel;
            audioSource.Play();
            if (ButtonFunctions.screenShakeOn)
            {
                cScript.ShakeCamera(2.5f, 0.1f);
            }
            switch (ButtonFunctions.vibration)
            {
                case 2:
                    HapticFeedback.LightFeedback();
                    break;
                case 3:
                    HapticFeedback.MediumFeedback();
                    break; 
            }
            pScript.ultCharge += 1;
            pScript.killCount += 1;
            pScript.score += 1;
            Destroy(collision.gameObject);
        }
        
    }
}
