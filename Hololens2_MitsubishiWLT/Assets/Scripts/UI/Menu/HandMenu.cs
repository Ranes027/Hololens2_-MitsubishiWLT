using UnityEngine;

namespace MitsubishiAR.UI
{
    public class HandMenu : MenuWindow
    {
        [SerializeField] private GameObject _adminButton;
        [SerializeField] private GameObject _mainMenuButton;

        public void MainMenuMode()
        {
            _mainMenuButton.SetActive(false);
            _adminButton.SetActive(true);
        }

        public void OutOfMainMenuMode()
        {
            _mainMenuButton.SetActive(true);
            _adminButton.SetActive(false);
        }
    }

}
