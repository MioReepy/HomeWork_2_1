using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

namespace HomeWork_2_1
{
    public class StartWindow : WindowBase
    {
        public static event Action LevelStarted;

        [SerializeField] private Button _setingsButton;
        [SerializeField] private Button _startButton;

        public override WindowType Type => WindowType.Start;
        public override bool IsPopup => false;

        private void Start()
        {
            _setingsButton.onClick.AddListener(OnSettingsButtonClick);
            _startButton.onClick.AddListener(OnStartButtonClick);
        }

        private void OnStartButtonClick()
        {
            LevelStarted?.Invoke();
            SceneManager.LoadScene("GameScene");
        }

        private void OnSettingsButtonClick()
        {
            UISystem.Instance.OpenWindow(WindowType.Setting, true);    
        }
    }
}