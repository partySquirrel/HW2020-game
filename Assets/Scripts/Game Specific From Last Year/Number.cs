using UnityEngine;

public class Number : MonoBehaviour
{
	public int value;
	public NumberManager manager;
	public string playerTag = "Player";

	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == playerTag)
			manager.NumberCollected(this);
	}
}
