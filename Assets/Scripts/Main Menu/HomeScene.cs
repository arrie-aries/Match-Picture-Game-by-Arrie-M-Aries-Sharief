using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;
using UnityEngine.UI;

namespace MatchPicture.Home
{
    public class HomeScene : MonoBehaviour
    {
        [SerializeField] private Button _playButton;
        [SerializeField] private Button _themeButton;
        public void Awake()
        {
            SetButtonListener();
        }
        private void SetButtonListener()
        {
            _playButton.onClick.RemoveAllListeners();
            _themeButton.onClick.RemoveAllListeners();

            _playButton.onClick.AddListener(OnClickedPlay);
            _themeButton.onClick.AddListener(OnClickedTheme);
        }
        public void OnClickedPlay()
        {
            SceneManager.LoadScene("Gameplay");
        }
        public void OnClickedTheme()
        {
            SceneManager.LoadScene("Theme");
        }

    }

}