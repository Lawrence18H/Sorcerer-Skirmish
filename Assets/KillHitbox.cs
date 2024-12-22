using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillHitbox : MonoBehaviour
{
    Player pScript;
    CinemachineFunctions cScript;
    ButtonFunctions bScript;
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
            if (ButtonFunctions.screenShakeOn)
            {
                cScript.ShakeCamera(2.5f, 0.1f);
            }
            pScript.ultCharge += 1;
            pScript.killCount += 1;
            Destroy(collision.gameObject);
        }
        
    }
}
