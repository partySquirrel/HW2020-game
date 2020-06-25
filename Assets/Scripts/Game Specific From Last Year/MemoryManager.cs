using UnityEngine;
using UnityEngine.Events;

public class MemoryManager : MonoBehaviour
{
	public float cardShowTime = 1f;
	public UnityEvent onMatch;
	public UnityEvent onMisMatch;

	MemoryCard heldCard;
	MemoryCard secondCard;

	public void CardClicked(MemoryCard newCard)
	{
		if (heldCard == null)
		{
			heldCard = newCard;
		}
		else
		{
			secondCard = newCard;
			Invoke("ProcessCards", cardShowTime);				
		}
	}

	void ProcessCards()
	{
		if (heldCard.value == secondCard.value)
		{
			onMatch.Invoke();
			heldCard.gameObject.SetActive(false);
			secondCard.gameObject.SetActive(false);
		}
		else
		{
			onMisMatch.Invoke();
			heldCard.Flip();
			secondCard.Flip();
		}

		heldCard = null;
		secondCard = null;
	}
}
