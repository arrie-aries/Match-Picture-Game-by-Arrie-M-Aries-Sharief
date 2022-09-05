using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MatchPicture.Gameplay
{
    public class GameplayScene : MonoBehaviour
    {
        [SerializeField] private Button _backButton;
        public void Awake()
        {
            SetButtonListener();
        }
        private void SetButtonListener()
        {
            _backButton.onClick.RemoveAllListeners();

            _backButton.onClick.AddListener(OnClickedBack);

        }
        public void OnClickedBack()
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}
