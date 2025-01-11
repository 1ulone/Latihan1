using UnityEngine;

class HighScoreRecordSystem : MonoBehaviour
{
	private int prevLevel;

	public void Record(int newLevel)
	{
		int lastHighScore = PlayerPrefs.GetInt("highscore", 0);

		if (lastHighScore < newLevel)
		{
			prevLevel = newLevel;
			PlayerPrefs.SetInt("highscore", prevLevel);
		}
	}
}
