using UnityEngine;
using UnityEngine.Events;

public class OnDeath : MonoBehaviour
{
	public UnityEvent onDeath;

	void OnDisable()
	{
		onDeath.Invoke();
	}
}
