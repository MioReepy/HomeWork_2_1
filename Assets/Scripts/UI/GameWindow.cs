
using TMPro;
using UnityEngine;

namespace HomeWork_2_1
{
    public class GameWindow : WindowBase
    {
        [SerializeField] private TextMeshProUGUI _scoreInfo;

        public override WindowType Type => WindowType.GameWindow;
        public override bool IsPopup => false;

        public static int _currentScore = 0;

        private void Update()
        {
            _scoreInfo.text = _currentScore.ToString();
        }
    }
}