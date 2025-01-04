using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using CandyCoded.HapticFeedback;

public class AnimEvents : MonoBehaviour
{

    public Player pScript;
    public ButtonFunctions bScript;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AttackEnd()
    {
        pScript.attacking = false;
    }
    public void AttackStart()
    {
        pScript.hitbox.SetActive(true);
    }
    public void AttackDownStart()
    {
        pScript.downHitbox.SetActive(true);
        
    }
    public void AttackDownEnd()
    {
        pScript.attackingDown = false;
    }
    

    public void UltimateStart()
    {
        pScript.ultimateHitbox.SetActive(true);
        switch (ButtonFunctions.vibration)
        {
            case 0:
                break;
            case 1:
                HapticFeedback.LightFeedback();
                break;
            case 2:
                HapticFeedback.MediumFeedback();
                break;
            case 3: 
                HapticFeedback.HeavyFeedback();
                break;
                //have light feedback on enemies and UI
        }
      
      
    }
    public void UltimateEnd()
    {
        pScript.animator.SetBool("Ultimating", false);
        pScript.ultimateHitbox.SetActive(false);
        pScript.ultCharge = 0;
    }
}
