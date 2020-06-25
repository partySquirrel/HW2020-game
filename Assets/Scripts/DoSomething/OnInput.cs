using UnityEngine;
using UnityEngine.Events;

public class OnInput : MonoBehaviour
{
	public bool triggerOncePerPress = false;
	public KeyCode targetButton = KeyCode.Mouse0;
	public UnityEvent onButtonPress;

    void Update()
    {
		if (triggerOncePerPress == true)
		{
			if (Input.GetKeyDown(targetButton))
				onButtonPress.Invoke();
		}
		else
		{
			if (Input.GetKey(targetButton))
				onButtonPress.Invoke();
		}
    }
}
