using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.LowLevel;

public class UIGamemanager : MonoBehaviour
{
#region 
UIGamemanager instance;
    private void Awake()
    {
        instance = this;
    }
    #endregion
     [SerializeField] Image[] Images;
    [SerializeField]Sprite[] Sprites;
    
    
   
    TextMeshProUGUI textodepontuação, textodorelogio;

    public void AtualizarSetas(KeyCode setas)
    {
        LoopUnit Image = Images;
       Update.Sprite.Get(setas)
       if(Array>= setas)
        {
            Sprite = sprites;
        }
        if (DownArrow)
        {
        Sprite sprites2;
        }
        if(UpArrow)
        {
        Sprite sprites3;
        }
        if(LeftArrow)
        {  
            Sprite sprites4;
        }

    }
}

