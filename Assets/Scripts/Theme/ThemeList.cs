using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MatchPicture.Theme
{
    public class ThemeList : MonoBehaviour
    {
        public Sprite[] faces;
        public Sprite back;
        public int faceIndex;
        public bool matched = false;
        SpriteRenderer spriteRenderer;
        GameObject gameControl;

        public enum ThemeSelection
        {
            Fruit,
            Food,
            Weapon,
            Random
        }
        private void Awake()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

    }
}