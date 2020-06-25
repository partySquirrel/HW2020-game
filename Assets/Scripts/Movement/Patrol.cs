using UnityEngine;

public class Patrol : MonoBehaviour
{
	public float timeToReachPosition = 5f;
	public Vector2 patrolDistance;

	Vector3 originalPosition;
	Vector3 targetPosition;
	Vector3 destination;
	Vector3 start;

	float ellapsedTime;

	void Start()
	{
		originalPosition = transform.position;
		start = originalPosition;
		targetPosition = originalPosition + (Vector3)patrolDistance;
		destination = targetPosition;
	}

    void Update()
    {
		ellapsedTime += Time.deltaTime / timeToReachPosition;
		transform.position = Vector3.Lerp(start, destination, ellapsedTime);

		if (ellapsedTime >= 1f)
		{
			ellapsedTime = 0f;
			transform.position = destination;
			start = destination;

			if (destination == targetPosition)
				destination = originalPosition;
			else
				destination = targetPosition;
		}
    }
}
