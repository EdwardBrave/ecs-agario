using UnityEngine;
using UnityEngine.UIElements;

namespace UI
{
    public class MainMenuViewModel : MonoBehaviour
    {
        public UIDocument document;
        
        public MainMenuDto mainMenuDto;
        
        public void Start()
        {
            document.rootVisualElement.Q<Button>("play-button").clickable.clicked += StartButtonClicked;
            document.rootVisualElement.Q<Button>("exit-button").clickable.clicked += ExitButtonClicked;
        }

        public void StartButtonClicked()
        {
            mainMenuDto.startCount++;
        }
        
        public void ExitButtonClicked()
        {
            mainMenuDto.exitCount++;
        }
    }
}