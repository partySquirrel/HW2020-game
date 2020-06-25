using UnityEngine;
using UnityEngine.Events;

public class OnClick : MonoBehaviour
{
	public UnityEvent onMouseClick;
	public UnityEvent onMouseEnter;
	public UnityEvent onMouseHover;
	public UnityEvent onMouseExit;

	void OnMouseEnter()
	{
		onMouseEnter.Invoke();
	}

	void OnMouseOver()
	{
		onMouseHover.Invoke();
	}

	void OnMouseExit()
	{
		onMouseExit.Invoke();
	}

	void OnMouseDown()
	{
		onMouseClick.Invoke();
	}
}
