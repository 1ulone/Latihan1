using UnityEngine;
using InteractionSystem;

public class SpikeController
{
    private InteractionSystem.OnTouchInterface _onTouchInterface = new OnTouchInterface();
    public void Spike()
    {
        _onTouchInterface.Touch(OnTouchInterface.InteractionType.Spike);
    }
}
