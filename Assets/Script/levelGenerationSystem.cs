using UnityEngine;

class levelGenerationSystem : MonoBehaviour
{
	[SerializeField] private GameObject[] levelLayouts;
	[SerializeField] private HighScoreRecordSystem recordSystem;
	private int prevLayoutIndex;
	private GameObject currentLayout;
	public int currentLevel { get; private set; }

	private void Awake()
	{
		prevLayoutIndex = 0;
		currentLevel = 1;

		GenerateRoom();
	}

	private void GenerateRoom()
	{
		int i = Random.Range(0, levelLayouts.Length);

		if (prevLayoutIndex != 0 && prevLayoutIndex == i)
			i+=1;
		if (i>=levelLayouts.Length)
			i=0;

		DestroyRoom();
		currentLayout = Instantiate(levelLayouts[i]);
	}

	private void DestroyRoom()
	{
		if (currentLayout == null)
			return;

		Destroy(currentLayout);
	}

	public void ResetGame()
	{
		DestroyRoom();
		
		prevLayoutIndex = 0;
		currentLevel = 1;

		GenerateRoom();
	}

	public void LevelUp()
	{
		currentLevel++;
	}

	public void GameEnd()
	{
		FindFirstObjectByType<movement>().gameObject.SetActive(false);
		recordSystem.Record(currentLevel);
		//Call Game Over UI
	}
}
