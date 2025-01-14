using UnityEngine;

class HighScoreRecordSystem : MonoBehaviour
{
	private int prevLevel;

	public int Record(int newLevel)
	{
		int lastHighScore = PlayerPrefs.GetInt("highscore");

		if (lastHighScore < newLevel)
		{
			prevLevel = newLevel;
			PlayerPrefs.SetInt("highscore", prevLevel);
		}
		else 
		{
			prevLevel = lastHighScore;
		}

		return prevLevel;
	}
}
