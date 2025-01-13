using System;
using UnityEngine;

namespace InteractionSystem
{
    public class OnTouchInterface
    {
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
                    Debug.Log("Dead!");
                    break;

                case InteractionType.DBlock:
                    Debug.Log("Dissapar");
                    break;

                case InteractionType.Goal:
                    //LevelUp();
                    break;
            }
        }
    }
}