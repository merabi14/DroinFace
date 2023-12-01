using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlayerMovment : MonoBehaviour
{
    public CharacterController2D controller;
    public float RunSpeed = 40f;
    float Horizonatlmovment = 0f;
    bool jump = false;

    void Update()
    {
         Horizonatlmovment = Input.GetAxisRaw("Horizontal") * RunSpeed;
         if(Input.GetButtonDown("Jump"))
         {
            jump = true;
         }
        //  Debug.Log(Horizonatlmovment);
        
    }

    void FixedUpdate()
    {
        controller.Move(Horizonatlmovment * Time.fixedDeltaTime, false, jump);
        jump = false;
        Debug.Log(Horizonatlmovment * Time.fixedDeltaTime );
        Debug.Log(jump);
    }
}
