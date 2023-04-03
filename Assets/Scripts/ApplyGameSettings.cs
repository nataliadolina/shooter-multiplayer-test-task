using UnityEngine;
using Utilities.Configuration;

internal class ApplyGameSettings : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = GameSettingsConfig.FPS;
    }
}
