using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafHit : MonoBehaviour
{
    public Animator leaf;
    public Animator pot;
    public int leafHealth = 3;

    private int leafHits = 0;

    void OnCollisionEnter2D(Collision2D collision)
	{
        leafHits++;
        if (leafHits >= leafHealth) {
		    leaf.SetTrigger("isLeafDead");
		    pot.SetTrigger("isLeafDead");
        }
	}
}
