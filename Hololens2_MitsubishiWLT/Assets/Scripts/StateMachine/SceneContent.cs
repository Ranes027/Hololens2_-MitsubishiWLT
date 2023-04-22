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
        [SerializeField] private StandInstructionMenu _standMenu;
        [Header("Animator Controller Settings")]
        [SerializeField] private RuntimeAnimatorController _sceneContentAnimator;
        [Header("Scene Objects")]
        [SerializeField] private GameObject[] _tips;
        [SerializeField] private GameObject[] _standInstObjects;
        [Space]
        public StateMachine SceneSM;
        public IdleState Idle;
        public AdminState Admin;
        public InfoState Info;
        public StandInstructionState StandInstruction;
        public ControllerCheckUpState ControllerCheckUp;

        public MainMenu MainMenu => _mainMenu;
        public AdminMenu AdminMenu => _adminMenu;
        public HandMenu HandMenu => _handMenu;
        public StandInstructionMenu StandMenu => _standMenu;

        public GameObject[] Tips => _tips;
        public GameObject[] StandInstObjects => _standInstObjects;

        private Coroutine _coroutine;
        private Animator _animator;
        private Animator Animator => _animator;

        public RuntimeAnimatorController SceneContentAnimator => _sceneContentAnimator;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        private void Start()
        {
            SceneSM = new StateMachine();

            Idle = new IdleState(this, SceneSM);
            Admin = new AdminState(this, SceneSM);
            Info = new InfoState(this, SceneSM);
            StandInstruction = new StandInstructionState(this, SceneSM);
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

        public void UpdateSceneAnimator(RuntimeAnimatorController animator)
        {
            if(_animator.runtimeAnimatorController != animator)
            {
                _animator.runtimeAnimatorController = animator;
            }
        }
    }

}
