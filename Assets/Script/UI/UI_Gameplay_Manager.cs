using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Gameplay_Manager : MonoBehaviour
{
	public static UI_Gameplay_Manager m;

    public UI_Timer timer { get; private set; }
    public UI_GameOver gameOver { get; private set; }
    public UI_LevelStatus levelStatus { get; private set; }
    
    [Header("Timer Settings")]
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;

    [Header("Game Over Settings")]
    [SerializeField] GameObject root;
    
    [Header("Level Settings")]
    [SerializeField] TextMeshProUGUI LevelLabel;

    void Awake()
    {
		m = this;

        timer = new UI_Timer(timerText, remainingTime);
        gameOver = new UI_GameOver(root, this, timer); 
        levelStatus = new UI_LevelStatus(LevelLabel);
    }

    void Update()
    {
        timer.countDown();
        if(!timer.isOver)
        {
//            levelStatus.UpdateLevel();//<==ganti level
//			gameOver.updateHighscore(levelStatus.NumberLevel);//<==update highscore
        }
        else
        {
            //disini ntar manggil gameover dari player
			//mati
            gameOver.ActivePanelGO();
            Debug.Log("Udahan");
        }
    }

	public void GameOverInit()
		=> gameOver.ActivePanelGO();

	public void GameOverTransition()
		=> StartCoroutine(gameOver.TransitionAlpha());

	public void Restart()
    {
        // Restart logic here
		SceneManager.LoadScene(0);
    }

    public void MainMenu()
    {
		Application.Quit();
    }
}
