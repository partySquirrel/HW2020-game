using UnityEngine;
using UnityEngine.Events;

public class OnAnyInput : MonoBehaviour
{
	public bool triggerOncePerPress = false;
	public UnityEvent onButtonPress;

    void Update()
    {
		if (triggerOncePerPress == true)
		{
			if (Input.anyKeyDown)
				onButtonPress.Invoke();
		}
		else
		{
			if (Input.anyKey)
				onButtonPress.Invoke();
		}
    }
}
