using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator m_animator;


    //Run
    public void Run(){
        // Reset timer
        // m_delayToIdle = 0.05f;
        m_animator.SetInteger("AnimState", 1);
    }
}
