using System;
using UnityEngine;

namespace InteractionSystem
{
    public class OnTouchInterface : MonoBehaviour
    {
        private InteractionSystem.D_BlockController _dBlockController;
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
        public void Touch(InteractionType typeOfInteraction)
        {
            switch (typeOfInteraction)
            {
                case InteractionType.Spike:
                    //GameEnd();
                    break;

                case InteractionType.DBlock:
                    _dBlockController.Touch();
                    break;

                case InteractionType.Goal:
                    //LevelUp();
                    break;
            }
        }
        
    }
}