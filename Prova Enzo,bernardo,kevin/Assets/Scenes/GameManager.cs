using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int pontos, teclaAtual;
    float relogio;
    KeyCode teclas;
    UIManager gamemanager;
    public void Start()
    {
        UIManager.Gerarsetas();
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)
        {
          Checartecla(DownArrow)
        }
        if (Input.GetKeyUp(KeyCode.Escape)
        {
            Checartecla(UpArrow)
        }
        if(Input.GetKeyRightArrow) 
        { 
         ChecarTecla(RightArrow)
        }
        if (Input.GetKeyLeftArrow)
        {
            ChecarTecla(LeftArrow)
        }
        ContagemRegressiva;

       public void ContagemRegressiva()
        {
            deltatime - relogio;
            textodepontuação.relogio.UIManager
            relogio <= 0;
        }
         private void Gerarsetas()
        {
            teclaAtual = 0;
            KeyCode = 10 == teclas
            loop array teclas
            {
               array= teclas = 273 && 276
            }
            relogio < teclas;
           UIManager.AtualizarSetas(teclas)
        }
        private void ChecarTecla(KeyCode teclaPressionada)
        {
            teclaPressionada == teclaAtual.array.teclas
            if (pontos.UIManager.Atualizarsetas.teclaatual(true))
            else if(pontos.relogio.UIManager.AtualizarSeta.teclaatual(false))
            UIManager.AtualizarTextos.pontos(relogio)
            teclaatual
                if(teclaAtual= teclas)
            {
                Gerarsetas();
            }

                    

            
        }
    }
}
