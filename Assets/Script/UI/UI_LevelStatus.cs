using TMPro;
using UnityEngine;

public class UI_LevelStatus 
{
    //dapetin data lvl ntar disini
    public int NumberLevel = 1;
    private TextMeshProUGUI textLabel;
    public UI_LevelStatus (TextMeshProUGUI text)
    {
        this.textLabel = text;
    }

    public void UpdateLevel()
    {
        textLabel.text = NumberLevel.ToString();
    }


}