using UnityEngine;

public class AutoRotate : MonoBehaviour
{
	public float speed = 0f;

    void Update()
    {
		transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }
}
