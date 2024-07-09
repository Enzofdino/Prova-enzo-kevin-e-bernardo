using JetBrains.Annotations;
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
        if(RightArrow)
        {
            Sprite sprites5;
        }
        Images = GetComponent<Image>().color = Color.white;
        private void AtualizarSeta(int setaSelecionada, bool acertou)
        {
            if (acertou)
            {
                Image = GetComponent<Image>().color = Color.green;
            }
            else if
                {
                Image = GetComponent<Image>().color = Color.red;
            }
        }
             Public void AtualizarTextos(int pontuação, float relogio)
        {
            Update.text.textodepontuação.value.pontuação = string;
            Update.text.textodorelogio.value.relogio = string;
        }         
        

    }
}

