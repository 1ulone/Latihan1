using UnityEngine;

namespace InteractionSystem
{
    public class GoalSystem : OnTouchInterface 
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
			FindFirstObjectByType<levelGenerationSystem>().LevelUp();
//            _onTouchInterface.Touch(OnTouchInterface.InteractionType.Goal);
        }
    }   
}
