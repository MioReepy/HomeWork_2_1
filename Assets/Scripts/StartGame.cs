using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HomeWork_2_1 
{
    public class StartGame : MonoBehaviour
    {
        [SerializeField] private GameObject _UI;
        [SerializeField] private GameObject _platform;
        [SerializeField] private GameObject _ball;
        [SerializeField] private GameObject _blocks;

        private int _countBlocks;
        private readonly float _ballOffset = 2f;

        private void Awake()
        {
            RestartGame();
        }
        private void Update()
        {
            if (FailBall._isFail)
            {
                RestartGame();
            }
        }

        private void RestartGame()
        {
            _UI.SetActive(true);
            FailBall._isFail = false;
            _countBlocks = _blocks.transform.childCount;
            _platform.transform.position = new Vector3(0, -3, 0);
            CommonData._currentScore = 0;

            CreateBall();

            for (int i = 0; i < _countBlocks; i++)
            {
                var _childBlock = _blocks.transform.GetChild(i);
                _blocks.transform.GetChild(i).gameObject.SetActive(true);
            }
        }

        private void CreateBall()
        {
            Instantiate(_ball, new Vector3(transform.position.x, transform.position.y + _ballOffset), Quaternion.identity);
        }
    }
}