using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MitsubishiAR.StateMachine;
using static MitsubishiAR.Components.Object.States.ActiveStateComponent;

namespace MitsubishiAR.UI
{
    public class MainMenu : MenuWindow
    {
        [SerializeField] private GameObject _general;
        [SerializeField] private GameObject _login;
        [SerializeField] private GameObject _settings;

        [SerializeField] private GameObject _backButton;

        public void ChangeStateFromMenu(string stateName)
        {
            var sceneContent = FindObjectOfType<SceneContent>();
            if (sceneContent != null)
            {
                switch (stateName)
                {
                    case "Info":
                        sceneContent.SceneSM.ChangeState(sceneContent.Info);
                        Debug.Log("Scene changed to Info");
                        break;
                    case "StandTurnOn":
                        sceneContent.SceneSM.ChangeState(sceneContent.StandTurnOn);
                        break;
                    case "ControllerCheckUp":
                        sceneContent.SceneSM.ChangeState(sceneContent.StandTurnOn);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Debug.Log("Add SceneContent to scene!");
            }

        }

        public void Login()
        {
            SubMenuSwitch(_settings, _login);
        }

        public void Settings()
        {
            SubMenuSwitch(_login, _settings);
        }

        public void Back()
        {
            _general.SetActive(true);
            _login.SetActive(false);
            _settings.SetActive(false);
            _backButton.SetActive(false);
        }

        private void SubMenuSwitch(GameObject _menuToCheck, GameObject _targetMenu)
        {
            if (_menuToCheck.activeSelf == false)
            {
                GameObject[] _objects = { _general, _targetMenu, _backButton };
                ChangeState(_objects);
            }
            else
            {
                GameObject[] _objects = { _menuToCheck, _targetMenu };
                ChangeState(_objects);
            }
        }
    }

}
