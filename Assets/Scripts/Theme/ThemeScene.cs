using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace MatchPicture.Theme
{
    public class ThemeScene : MonoBehaviour
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