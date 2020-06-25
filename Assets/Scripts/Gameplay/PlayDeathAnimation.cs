using UnityEngine;

public class PlayDeathAnimation : MonoBehaviour
{
	public GameObject childObject;

	public void PlayAnimation()
	{
		childObject.transform.parent = null;
		childObject.SetActive(true);
	}
}
