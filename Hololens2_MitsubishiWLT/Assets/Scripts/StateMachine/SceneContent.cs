using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using MitsubishiAR.UI;


namespace MitsubishiAR.StateMachine
{
    public class SceneContent : MonoBehaviour
    {
        [Header("Scene Menus")]
        [SerializeField] private MainMenu _mainMenu;
        [SerializeField] private AdminMenu _adminMenu;
        [SerializeField] private HandMenu _handMenu;
        [Header("Scene Objects")]
        [SerializeField] private GameObject[] _tips;
        [Space]
        public StateMachine SceneSM;
        public IdleState Idle;
        public AdminState Admin;
        public InfoState Info;
        public StandTurnOnState StandTurnOn;
        public ControllerCheckUpState ControllerCheckUp;

        public MainMenu MainMenu => _mainMenu;
        public AdminMenu AdminMenu => _adminMenu;
        public HandMenu HandMenu => _handMenu;

        public GameObject[] Tips => _tips;

        private Coroutine _coroutine;

        private void Start()
        {
            SceneSM = new StateMachine();

            Idle = new IdleState(this, SceneSM);
            Admin = new AdminState(this, SceneSM);
            Info = new InfoState(this, SceneSM);
            StandTurnOn = new StandTurnOnState(this, SceneSM);
            ControllerCheckUp = new ControllerCheckUpState(this, SceneSM);

            SceneSM.Initialize(Idle);

            if (_coroutine != null) StopCoroutine(_coroutine);
            _coroutine = StartCoroutine(LateStart());
        }

        private void Update()
        {
            SceneSM.CurrentState.LogicUpdate();
        }

        private IEnumerator LateStart()
        {
            yield return new WaitForEndOfFrame();

            SceneSM.CurrentState.LateEnter();
        }


    }

}
