using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void GameOver()
    {   
        foreach (var item in GameObject.FindGameObjectsWithTag("Bug"))
        {
            item.GetComponent<BugDeath>().enabled = false;
        }        
    }
}
