using System.Collections;
using System.Collections.Generic;
using MitsubishiAR.Model.Data;
using UnityEngine;
using UnityEngine.Events;

namespace MitsubishiAR.UI.Text
{
    public class InfoWindowController : MonoBehaviour
    {
        [Header("Window and buttons")]
        [SerializeField] private GameObject _container;
        [SerializeField] private GameObject _nextButton;
        [SerializeField] private GameObject _previousButton;
        [SerializeField] private GameObject _exitButton;
        [Space][SerializeField] protected InfoContent _content;

        private InfoData _data;
        private int _currentSentence;

        private UnityEvent _onComplete;
        private UnityEvent _onExit;

        protected Sentence CurrentSentence => _data.Sentences[_currentSentence];
        protected virtual InfoContent CurrentContent => _content;

        public void ShowInfo(InfoData data, UnityEvent onComplete, UnityEvent onExit)
        {
            _data = data;
            _onComplete = onComplete;
            _onExit = onExit;
            _currentSentence = 0;
            CurrentContent.Text.text = CurrentSentence.Value;

            _container.SetActive(true);
            CheckSentences();
        }

        public void OnBack()
        {
            if (_currentSentence > 0)
                _currentSentence--;
            CheckSentences();

            CurrentContent.Text.text = CurrentSentence.Value;
        }

        public void OnContinue()
        {
            _currentSentence++;
            CheckSentences();

            CurrentContent.Text.text = CurrentSentence.Value;
        }

        public void OnExit()
        {
            _container.SetActive(false);
            _exitButton.SetActive(false);
            _previousButton.SetActive(false);
            _onExit?.Invoke();
        }

        private void CheckSentences()
        {
            var isInfoComplete = _currentSentence >= _data.Sentences.Length - 1;
            if (isInfoComplete)
            {
                _nextButton.SetActive(false);
                _exitButton.SetActive(true);
                _onComplete?.Invoke();
            }
            else
            {
                _nextButton.SetActive(true);
                _exitButton.SetActive(false);
            }

            var isCanGoBack = _currentSentence > 0;
            if (isCanGoBack)
                _previousButton.SetActive(true);
            else
                _previousButton.SetActive(false);
        }
    }

}
