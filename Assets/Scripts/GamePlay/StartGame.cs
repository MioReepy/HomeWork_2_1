using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HomeWork_2_1 
{
    public class StartGame : MonoBehaviour
    {
        [SerializeField] private GameObject _UICompleteLevel;
        [SerializeField] private GameObject _ball;
        [SerializeField] private GameObject _blocks;

        public static int _countBlocks;

        private readonly float _ballOffset = 2f;

        private void Awake()
        {
            GameWindow._currentScore = 0;
            _countBlocks = _blocks.transform.childCount;
        }

        private void Update()
        {
            if (_countBlocks == 0)
            {
                Time.timeScale = 0;
                _UICompleteLevel.gameObject.SetActive(true);
            }

        }

        private void CreateBall()
        {
            Instantiate(_ball, new Vector3(transform.position.x, transform.position.y + _ballOffset), Quaternion.identity);
        }
    }
}