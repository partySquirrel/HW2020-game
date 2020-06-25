using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkToTarget : MonoBehaviour
{
	public Transform target;
    public float speed = 1;

	void Start()
	{
		
    }

    void Update()
    {
		if (target != null) {

            // The step size is equal to speed times frame time.
            float singleStep = speed * Time.deltaTime;

            // Determine which direction to rotate towards
            Vector3 targetDirection = target.position - transform.position;

            // rotates the object to target angle
            float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
                        
			// Moves the object to target position
            transform.position = Vector3.MoveTowards(transform.position, target.position, singleStep);
            
        }
    }
}
