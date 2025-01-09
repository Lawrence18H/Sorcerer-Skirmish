using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CandyCoded.HapticFeedback;
public class EnemyHitbox : MonoBehaviour
{
    Player pScript;
    CinemachineFunctions cScript;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        pScript = FindObjectOfType<Player>();
        cScript = FindObjectOfType<CinemachineFunctions>();
        GameObject audio = GameObject.Find("SoundEffect");
        audioSource = audio.GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("Player"))
        {
            
            audioSource.pitch = 0.3f;
            audioSource.Play();
            if (!pScript.damaged)
            {
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
                pScript.health -= 1;
                pScript.damaged = true;
                
            }
            
        }

    }
}
