using UnityEngine;
using InteractionSystem;

public class GoalSystem
{
    private InteractionSystem.OnTouchInterface _onTouchInterface = new OnTouchInterface();
    public void Goal()
    {
        _onTouchInterface.Touch(OnTouchInterface.InteractionType.Goal);
    }
}
