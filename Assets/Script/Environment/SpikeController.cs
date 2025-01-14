using UnityEngine;

namespace InteractionSystem
{
    public class SpikeController : OnTouchInterface 
    {
		/*
        private OnTouchInterface _onTouchInterface;
		private void Awake()
		{
			_onTouchInterface = FindFirstObjectByType<OnTouchInterface>(); 
		}
		*/

        protected override void TouchEvent()
        {
			FindFirstObjectByType<levelGenerationSystem>().GameEnd();
//            _onTouchInterface.Touch(OnTouchInterface.InteractionType.Spike);
        }
    }   
}
