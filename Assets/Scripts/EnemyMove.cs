using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject player;
    public Transform sprite;
    public float speed;
    public float distance;
    public Rigidbody2D rb;
    
    public bool canAttack;
    public float timer;
    public float time;
    public GameObject hitbox;
    // Start is called before the first frame update
    void Start()
    {
        Player pScript = FindObjectOfType<Player>();
        player = pScript.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = gameObject.transform.position;
        if (gameObject.transform.position.x > player.transform.position.x)
        {
            if (gameObject.transform.position.x < player.transform.position.x + distance)
            {
                pos.x = pos.x;
                canAttack = true;
                
            }
            else
            {
                pos.x -= speed * Time.deltaTime;
                transform.localScale = new Vector3(-1, 1, 1);
            }
            
        }
        else if (gameObject.transform.position.x < player.transform.position.x)
        {
            if (gameObject.transform.position.x > player.transform.position.x - distance)
            {
                pos.x = pos.x;
                canAttack = true;
                
            }
            else
            {
                pos.x += speed * Time.deltaTime;
                transform.localScale = new Vector3(1, 1, 1);
            }
           
        }
        if (canAttack)
        {
            timer -= Time.deltaTime;
        }
        gameObject.transform.position = pos;
    }
    
}
