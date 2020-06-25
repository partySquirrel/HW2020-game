using UnityEngine;

public class GameQuitter : MonoBehaviour
{
    void Update()
    {
		if (Input.GetButtonDown("Cancel"))
		{
			Application.Quit();
		}
	}
}
