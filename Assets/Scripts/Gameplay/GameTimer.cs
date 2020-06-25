using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
	public float targetTime = 30f;
	public Text timeText;
	public UnityEvent onTargetTimeReached;

	float elapsedTime;
	bool triggered = false;

	void Update()
    {
		elapsedTime += Time.deltaTime;

		if (timeText != null)
			timeText.text = elapsedTime.ToString("F0");

		if (elapsedTime >= targetTime && triggered == false)
		{
			triggered = true;

			onTargetTimeReached.Invoke();
		}
	}
}
