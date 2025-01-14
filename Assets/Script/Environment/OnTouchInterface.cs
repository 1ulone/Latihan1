using UnityEngine;

namespace InteractionSystem
{
    public class OnTouchInterface : MonoBehaviour
    {
        private D_BlockController _dBlockController;
        public enum InteractionType
        {
            Spike,
            DBlock,
            Goal
        }
        /// <summary>
        /// Respon to different type of interaction that happens inside the game
        /// </summary>
        /// <param name="typeOfInteraction">Specify the type of the interaction</param>
        public void Touch()
        {
			TouchEvent();	

			/*
            switch (typeOfInteraction)
            {
                case InteractionType.Spike:
					Debug.Log("nigga");
                    break;

                case InteractionType.DBlock:
                    _dBlockController.Touch();
                    break;

                case InteractionType.Goal:
					Debug.Log("you won");
                    break;
            }
			*/
        }
		
		protected virtual void TouchEvent() {}
    }
}
