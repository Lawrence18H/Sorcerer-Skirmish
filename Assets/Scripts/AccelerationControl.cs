using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerationControl : MonoBehaviour
{
    //https://www.youtube.com/watch?v=0DLSIVOsMv8
    Vector3 accelerationDir;
    Player pScript;
    // Start is called before the first frame update
    void Start()
    {
        pScript = FindObjectOfType<Player>();
    }
        
    // Update is called once per frame
    void Update()
    {
        accelerationDir = Input.acceleration;
        if (accelerationDir.sqrMagnitude >= 7f)
        {
            if (ButtonFunctions.shakeOn)
            {
                pScript.timer = 0;

            }
            
            
        }
        //have ultimate attack vary on how long device is shook
    }
}
