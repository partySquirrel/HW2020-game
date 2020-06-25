using UnityEngine;

public class ColorChanger : MonoBehaviour
{
	[Header("Be sure to set transparency as well as color")]
	public Color[] colors;

	public void ChangeColor(int number)
	{
		SpriteRenderer renderer = GetComponent<SpriteRenderer>();

		if (renderer != null)
			renderer.color = colors[number];
	}
}
