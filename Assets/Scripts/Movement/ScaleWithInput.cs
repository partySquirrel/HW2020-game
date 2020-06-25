using UnityEngine;

public class ScaleWithInput : MonoBehaviour
{
	public float speed = 0f;

	public KeyCode scaleUpButton = KeyCode.UpArrow;
	public KeyCode scaleDownButton = KeyCode.DownArrow;


	void Update()
	{
		float amount = speed * Time.deltaTime;

		if (Input.GetKey(scaleUpButton))
			transform.localScale = transform.localScale + (Vector3.one * amount);

		if (Input.GetKey(scaleDownButton))
			transform.localScale = transform.localScale - (Vector3.one * amount);
	}
}
