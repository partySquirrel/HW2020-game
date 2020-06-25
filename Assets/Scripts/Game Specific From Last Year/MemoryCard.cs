using UnityEngine;

public class MemoryCard : MonoBehaviour
{
	public int value;
	public MemoryManager manager;

	Collider2D targetCollider;
	GameObject cardImage;

    void Start()
    {
		targetCollider = GetComponent<Collider2D>();
		cardImage = GetComponentInChildren<SpriteRenderer>().gameObject;
    }

	void OnMouseDown()
	{
		targetCollider.enabled = false;
		cardImage.SetActive(true);
	}

	public void Flip()
	{
		cardImage.SetActive(false);
		targetCollider.enabled = true;
	}
}
