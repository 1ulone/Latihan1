using System.Collections;
using TMPro;
using UnityEngine;

public class UI_GameOver
{
    private const float TRANTITION_SPEED = 0.5f;
    private GameObject root;
    private CanvasGroup rootCG;
    private TextMeshProUGUI highscoreLabel;
	private UI_Gameplay_Manager manager;
	private UI_Timer timer;
    private bool isTransitioning = false;

    public UI_GameOver(GameObject roots, UI_Gameplay_Manager manager, UI_Timer timer)
    {
        this.root = roots;
        Transform highscoreTextTransform = root.transform.Find("Panel/Text - Score");
        this.highscoreLabel = highscoreTextTransform.GetComponent<TextMeshProUGUI>();
        rootCG = root.GetComponent<CanvasGroup>();
		this.manager = manager;
        rootCG.alpha = 0;
		this.timer = timer;
    }

    public void ActivePanelGO()
    {
        if (isTransitioning)
        {
            Debug.Log("Transition already in progress. Please wait.");
            return;
        }

		timer.stop = true;

        root.SetActive(true);
        isTransitioning = true;
        manager.GameOverTransition();
    }

    public void updateHighscore(int currentHighscore)
    {
        highscoreLabel.text = "Level "+currentHighscore.ToString();
    }

    public IEnumerator TransitionAlpha()
    {
        while (rootCG.alpha < 1)
        {
            rootCG.alpha = Mathf.Lerp(rootCG.alpha, 1, Time.deltaTime * TRANTITION_SPEED);
            yield return null;
        }

        rootCG.alpha = 1;
        isTransitioning = false;
    }


}
