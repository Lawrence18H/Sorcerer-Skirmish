using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitbox : MonoBehaviour
{
    Player pScript;
    
    // Start is called before the first frame update
    void Start()
    {
        pScript = FindObjectOfType<Player>();
        
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
            if (!pScript.damaged)
            {
                pScript.health -= 1;
                
                pScript.damaged = true;
                
            }
            
        }

    }
}
