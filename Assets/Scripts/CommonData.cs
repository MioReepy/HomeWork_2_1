using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Tilemaps;
using UnityEngine;

namespace HomeWork_2_1
{
    public class CommonData : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _scoreInfo;

        public static int _currentScore = 0;

        private void Update()
        {
            _scoreInfo.text = _currentScore.ToString();
        }
    }
}