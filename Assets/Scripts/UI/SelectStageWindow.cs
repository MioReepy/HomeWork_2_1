using System;
using UnityEngine;
using UnityEngine.UI;

namespace HomeWork_2_1
{
    public class SelectStageWindow : WindowBase
    {
        [SerializeField] private Button _backButton;

        public override WindowType Type => WindowType.SelectStage;
        public override bool IsPopup => false;

        private void Start()
        {
            _backButton.onClick.AddListener(OnBackButtonClick);
        }

        private void OnBackButtonClick()
        {
            UISystem.Instance.OpenWindow(WindowType.Start, false);
        }
    }
}