﻿using UnityEngine;
using System.Collections;

namespace Snake
{
    public class LoadOptionsMenu : MonoBehaviour
    {
        public GameObject optionsMenu;

        public void HideMain()
        {
            gameObject.SetActive(false);
        }

        public void ShowOptions()
        {
            optionsMenu.SetActive(true);
        }
    }
}