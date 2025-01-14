using UnityEngine;

class levelGenerationSystem : MonoBehaviour
{
	[SerializeField] private GameObject[] levelLayouts;
	[SerializeField] private Transform TilemapParent;
	private HighScoreRecordSystem recordSystem;
	private int prevLayoutIndex;
	private GameObject currentLayout;
	public int currentLevel { get; private set; }

	private void Awake()
	{
		recordSystem = GetComponent<HighScoreRecordSystem>();

		prevLayoutIndex = 0;
		currentLevel = 1;

		GenerateRoom();
	}

	private void Start()
		=> UI_Gameplay_Manager.m.levelStatus.UpdateLevel(currentLevel);

	private void GenerateRoom()
	{
		int i = Random.Range(0, levelLayouts.Length);

		if (prevLayoutIndex != 0 && prevLayoutIndex == i)
			i+=1;
		if (i>=levelLayouts.Length)
			i=0;

		DestroyRoom();
		currentLayout = Instantiate(levelLayouts[i], Vector3.zero, Quaternion.identity, TilemapParent);
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
		UI_Gameplay_Manager.m.levelStatus.UpdateLevel(currentLevel);

		GenerateRoom();
	}

	public void LevelUp()
	{
		DestroyRoom();

		currentLevel++;

		UI_Gameplay_Manager.m.timer.ResetTime(currentLevel);
		UI_Gameplay_Manager.m.levelStatus.UpdateLevel(currentLevel);

		GenerateRoom();
	}

	public void GameEnd()
	{
		FindFirstObjectByType<movement>().gameObject.SetActive(false);
		int score = recordSystem.Record(currentLevel);
		UI_Gameplay_Manager.m.gameOver.updateHighscore(score);
		UI_Gameplay_Manager.m.gameOver.ActivePanelGO();
	}
}
