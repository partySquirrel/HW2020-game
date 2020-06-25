using UnityEngine;

public class StopAllTime : MonoBehaviour
{
	float originalTimeScale;

	public void StopTime()
	{
		originalTimeScale = Time.timeScale;
		Time.timeScale = 0f;
	}

	public void StartTime()
	{
		if (originalTimeScale == 0)
			return;

		Time.timeScale = originalTimeScale;
	}
}
