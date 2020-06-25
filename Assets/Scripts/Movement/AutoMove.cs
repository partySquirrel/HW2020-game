using UnityEngine;

public class AutoMove : MonoBehaviour
{
	public Vector2 speedPerAxis;
	public bool moveRelativeToRotation = false;

	Space mode;

	void Update()
    {
		if (moveRelativeToRotation == true)
			mode = Space.Self;
		else
			mode = Space.World;

		transform.Translate(speedPerAxis * Time.deltaTime, mode);
	}
}
