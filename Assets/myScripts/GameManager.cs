using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Animator animator;

    public void GameOver()
    {   
        StopBugClicks();   
    }
    public void GameWon()
    {   
        StopBugClicks(); 
        animator.SetTrigger("isPotSmiling");         
    }

    public void LevelWon()
    {   
         StopBugClicks();    
         animator.SetTrigger("isPotSmiling");       
    }
    
    void StopBugClicks() {
        foreach (var item in GameObject.FindGameObjectsWithTag("Bug"))
        {
            item.GetComponent<BugDeath>().enabled = false;
        }     
    }
}
