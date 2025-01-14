using TMPro;
using UnityEngine;

public class UI_Gameplay_Manager : MonoBehaviour
{
    private UI_Timer timer;
    private UI_GameOver gameOver;
    private UI_LevelStatus levelStatus;
    
    [Header("Timer Settings")]
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;

    [Header("Game Over Settings")]
    [SerializeField] GameObject root;
    
    [Header("Level Settings")]
    [SerializeField] TextMeshProUGUI LevelLabel;

    void Start()
    {
        
        timer = new UI_Timer(timerText, remainingTime);
        gameOver = new UI_GameOver(root, this); 
        levelStatus = new UI_LevelStatus(LevelLabel);
    }

    void Update()
    {
        timer.countDown();
        if(!timer.isOver)
        {
            levelStatus.UpdateLevel();
           gameOver.updateHighscore(levelStatus.NumberLevel);
        }
        else
        {
            //disini ntar manggil gameover dari player
            gameOver.ActivePanelGO();
            Debug.Log("Udahan");
        }
    }
}
