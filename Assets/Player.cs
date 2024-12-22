using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public GameObject hitbox;
    public GameObject downHitbox;
    public GameObject ultimateHitbox;
    public Vector3 mousePos;
    public Animator animator;
    public bool attacking;
    public float timer;
    public float time;
    public GameObject Health1;
    public GameObject Health2;
    public GameObject Health3;
    public GameObject Ult1;
    public GameObject Ult2;
    public GameObject Ult3;
    public float health;
    public float ultCharge;
    public bool damaged;
    public float iFrameTimer;
    public float iFrameTime;
    public bool hasAttacked;
    public float killCount;
    public GameObject lightningRight;
    public GameObject lightningLeft;
    public bool attackingDown;

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0 && ultCharge >= 9)
        {
            animator.SetBool("Ultimating", true);

        }
        detectInput();
        if (damaged)
        {
            iFrameTimer -= Time.deltaTime;
        }
        if (iFrameTimer <= 0)
        {
            damaged = false;
            iFrameTimer = iFrameTime;
        }
        if (health == 3)
        {
            Health1.SetActive(true);
            Health2.SetActive(true);
            Health3.SetActive(true);
        }
        else if (health == 2)
        {
            Health3.SetActive(false);
        }
        else if (health == 1)
        {
            Health2.SetActive(false);
        }
        else if (health == 0)
        {
            Health1.SetActive(false);
        }
        if (ultCharge <= 3)
        {
            Ult1.SetActive(false);
            Ult2.SetActive(false);
            Ult3.SetActive(false);
        }
        else if (ultCharge >= 3 && ultCharge <= 6)
        {
            Ult1.SetActive(true);
        }
        else if (ultCharge >= 6 && ultCharge <= 9)
        {
            Ult2.SetActive(true);
        }    
        else
        {
            Ult3.SetActive(true);
        }
        if (attacking)
        {
            animator.SetBool("Attacking", true);
        }
        else if (!attacking)
        {
            hitbox.SetActive(false);
            animator.SetBool("Attacking", false);
        }
        if (attackingDown)
        {
            animator.SetBool("AttackingDown", true);
        }
        else if (!attackingDown) 
        {
            downHitbox.SetActive(false);
            animator.SetBool("AttackingDown", false);
        }
    }
    private IEnumerator Lightning(GameObject go)
    {
        go.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        go.SetActive(false);
    }
    void detectInput()
    {
        if (Input.touchCount > 0)
        {
            //Debug.Log("touching");
            timer -= Time.deltaTime;
            mousePos = Input.mousePosition;
            if (mousePos.y > 500)
            {
                if (mousePos.x < 750 && !hasAttacked)
                {
                    StartCoroutine(Lightning(lightningLeft));
                    hasAttacked = true;
                }
                else if (mousePos.x > 750 && !hasAttacked)
                {
                    StartCoroutine(Lightning(lightningRight));
                    hasAttacked = true;
                }
            }
            else if (mousePos.y < 500 && mousePos.y > 175)
            {
                if (mousePos.x < 750 && !hasAttacked)
                {
                    gameObject.transform.localScale = new Vector3(-1, 1, 1);
                    attacking = true;
                    hasAttacked = true;
                }
                else if (mousePos.x > 750 && !hasAttacked)
                {
                    
                    gameObject.transform.localScale = new Vector3(1, 1, 1);
                    attacking = true;
                    hasAttacked = true;
                }
            }
            else if (mousePos.y < 175)
            {
                if (mousePos.x < 750 && !hasAttacked)
                {
                    
                    gameObject.transform.localScale = new Vector3(-1, 1, 1);
                    attackingDown = true;
                    hasAttacked = true;
                }
                else if (mousePos.x > 750 && !hasAttacked)
                {
                    
                    gameObject.transform.localScale = new Vector3(1, 1, 1);
                    attackingDown = true;
                    hasAttacked = true;
                }
            }
        }
        else
        {
            timer = time;
            hasAttacked = false;
        }
    }
}
