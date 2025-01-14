using TMPro;

public class UI_LevelStatus 
{
    //dapetin data lvl ntar disini
    private TextMeshProUGUI textLabel;

    public UI_LevelStatus (TextMeshProUGUI text)
    {
        this.textLabel = text;
    }

    public void UpdateLevel(int level)
    {
        textLabel.text = level.ToString();
    }
}
