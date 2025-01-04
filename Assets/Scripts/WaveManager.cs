using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy;
    public Transform spawn1;
    public Transform spawn2;
    public float timer;
    public float time;
    public Transform spawnSide;
    public Player pScript;
    public float maxTime;
    
    // Start is called before the first frame update
    void Start()
    {
        pScript = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        time = maxTime - pScript.killCount * 0.1f;
        if (time < 2)
        {
            time = 2;
        }
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else if (timer <= 0)
        {
            int enemyToSpawn = Random.Range(1, 4);
            Debug.Log(enemyToSpawn);
            if (enemyToSpawn == 1)
            {
                enemy = enemy1;
                spawn1.position = new Vector3(-10, 0.3f, 0);
                spawn2.position = new Vector3(10, 0.3f, 0);
            }
            else if (enemyToSpawn == 2)
            {
                enemy = enemy2;
                spawn1.position = new Vector3(-10, 0.3f, 0);
                spawn2.position = new Vector3(10, 0.3f, 0);
            }
            else if (enemyToSpawn == 3)
            {
                enemy = enemy3;
                spawn1.position = new Vector3(-10, 0.7f, 0);
                spawn2.position = new Vector3(10, 0.7f, 0);
            }
           
            int spawnLocation = Random.Range(1, 10);
            if (spawnLocation >= 5)
            {
                spawnSide = spawn1;
            }
            else if (spawnLocation <= 5)
            {
                spawnSide = spawn2;
            }
            Instantiate(enemy, spawnSide.position, Quaternion.identity);
            timer = time;
        }
        
        
    }
}
