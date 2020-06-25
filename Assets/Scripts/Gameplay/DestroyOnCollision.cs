using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
	public string tagToCollideWith = "";
	public bool destroyThisObject = true;
	public bool destroyOtherObject = false;

	void OnCollisionEnter2D(Collision2D collision)
	{
		Collide(collision.gameObject);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Collide(other.gameObject);	
	}

	void Collide(GameObject otherObject)
	{
		if (tagToCollideWith != "" && otherObject.tag != tagToCollideWith)
			return;

		if (destroyOtherObject == true)
			Destroy(otherObject);

		if (destroyThisObject == true)
			Destroy(gameObject);
	}
}
