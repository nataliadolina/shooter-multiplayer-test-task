using UnityEngine;
using System;
using Game.UI.Abstract;
using Game.UI.Interfaces;

namespace Game.UI
{
    internal sealed class PlayerDirectionInput : JoystickAreaHandler, IPlayerDirectionInput
    {
        /// <summary>
        /// Vector2: direction
        /// </summary>
        public event Action<Vector2> onCharacterDirectionChanged;

        private protected override void UpdatePlayerDirection(in Vector2 direction)
        {
            onCharacterDirectionChanged?.Invoke(direction);
        }
    }
}
