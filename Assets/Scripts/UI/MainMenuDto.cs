using Unity.Properties;
using UnityEngine;

namespace UI
{
    [CreateAssetMenu(fileName = "MainMenuDto", menuName = "UI/MainMenuDto")]
    public class MainMenuDto : ScriptableObject
    {
        public int startCount;
        public int exitCount;
        [CreateProperty]
        public string InfoText => $"Start: {startCount}, Exit: {exitCount}";
    }
}