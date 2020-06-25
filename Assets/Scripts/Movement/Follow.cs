using UnityEngine;

public class Follow : MonoBehaviour
{
	public Transform target;

	Vector3 offset;

    void Start()
    {
		if(target != null)
			offset = transform.position - target.position;
    }

    void LateUpdate()
    {
		if (target != null)
			transform.position = target.position + offset;
    }
}
