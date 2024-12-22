using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimEvents : MonoBehaviour
{
    public Animator animator;
    public EnemyMove enemyScript;
    // Start is called before the first frame update
    void Start()
    {
        enemyScript = FindObjectOfType<EnemyMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyScript.timer < 0)
        {
            animator.SetBool("IsAttacking", true);
            enemyScript.timer = enemyScript.time;
        }
    }
    public void StopAttacking()
    {
        enemyScript.hitbox.SetActive(false);
        animator.SetBool("IsAttacking", false);
    }
    public void StartAttacking()
    {
        enemyScript.hitbox.SetActive(true);
        animator.SetBool("IsAttacking", true);
    }
}
