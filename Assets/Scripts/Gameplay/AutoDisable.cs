using UnityEngine;

public class AutoDisable : MonoBehaviour
{
	public float timeUntilDisable = 3f;

    void OnEnable()
    {
		Invoke("Disable", timeUntilDisable);
    }

	void Disable()
	{
		CancelInvoke();
		gameObject.SetActive(false);
	}
}
