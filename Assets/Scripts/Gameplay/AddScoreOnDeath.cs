using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScoreOnDeath : MonoBehaviour
{
	Score score;

	private void Start()
	{
		score = FindObjectOfType<Score>();
	}

	private void OnDisable()
	{
		if (score != null)
			score.AddScore();
	}
}
