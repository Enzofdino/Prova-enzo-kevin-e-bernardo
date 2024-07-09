using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;

public class UIGamemanager : MonoBehaviour
{
    #region 
    UIGamemanager instance;
    private void Awake()
    {
        instance = this;
    }
    #endregion
    [SerializeField]
    Array Sprite;
    [SerializeField]
    Array Image;
    TextMeshProUGUI textodepontuação, textodorelogio;
}
