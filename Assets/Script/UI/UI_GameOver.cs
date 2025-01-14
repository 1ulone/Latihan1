using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class UI_GameOver
{
    private const float TRANTITION_SPEED = 0.5f;
    private GameObject root;
    private CanvasGroup rootCG;
    private TextMeshProUGUI highscoreLabel;
    private bool isTransitioning = false;

    private MonoBehaviour manager;

    public UI_GameOver(GameObject roots, MonoBehaviour manager)
    {
        this.root = roots;
        Transform highscoreTextTransform = root.transform.Find("Panel/Text - Score");
        this.highscoreLabel = highscoreTextTransform.GetComponent<TextMeshProUGUI>();
        this.manager = manager;
        rootCG = root.GetComponent<CanvasGroup>();
        rootCG.alpha = 0;
    }

    public void ActivePanelGO()
    {
        if (isTransitioning)
        {
            Debug.Log("Transition already in progress. Please wait.");
            return;
        }

        root.SetActive(true);
        isTransitioning = true;
        manager.StartCoroutine(TransitionAlpha());
    }

    public void updateHighscore(int currentHighscore)
    {
        highscoreLabel.text = currentHighscore.ToString();
    }

    private IEnumerator TransitionAlpha()
    {
        while (rootCG.alpha < 1)
        {
            rootCG.alpha = Mathf.Lerp(rootCG.alpha, 1, Time.deltaTime * TRANTITION_SPEED);
            yield return null;
        }

        rootCG.alpha = 1;
        isTransitioning = false;
    }

    public void Restart()
    {
        // Restart logic here
        Debug.Log("Restart");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
