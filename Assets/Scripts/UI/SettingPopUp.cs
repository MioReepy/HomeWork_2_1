using System;
using UnityEngine;
using UnityEngine.UI;

namespace HomeWork_2_1
{
    public class SettingPopUp : WindowBase
    {
        [SerializeField] private Button _backButton;

        public override WindowType Type => WindowType.Setting;
        public override bool IsPopup => true;

        private void Start()
        {
            _backButton.onClick.AddListener(OnBackButtonClick);
        }

        private void OnBackButtonClick()
        {
            UISystem.Instance.Close(Type);
        }
    }
}