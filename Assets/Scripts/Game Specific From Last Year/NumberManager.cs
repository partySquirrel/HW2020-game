using UnityEngine;
using UnityEngine.Events;

public class NumberManager : MonoBehaviour
{
	public Transform playerRestartPoint;
	public GameObject player;
	public int[] phoneNumber;
	public GameObject[] uiNumbers;
	public UnityEvent onNumberCompleted;

	int currentNumber;

	public void NumberCollected(Number number)
	{
		if (currentNumber >= phoneNumber.Length)
			return;

		int targetNumber = phoneNumber[currentNumber];
		int givenNumber = number.value;

		if (givenNumber == targetNumber)
		{
			uiNumbers[currentNumber].SetActive(true);
			currentNumber++;
			if (currentNumber >= phoneNumber.Length)
				onNumberCompleted.Invoke();
		}
		else
		{
			player.transform.position = playerRestartPoint.position;
		}
	}
}
