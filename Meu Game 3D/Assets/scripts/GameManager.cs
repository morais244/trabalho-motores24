using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI hud, MsgVitoria;
    public int restantes;
    
    
    // Start is called before the first frame update
    void Start()
    {
        restantes = FindObjectsOfType<moeda>().Length;

        hud.text = $"moedas restantes: {restantes}";
    }

    public void SubtrairMoedas(int valor)
    {
        restantes -= restantes - valor;

        if (restantes <= 0)
        {
            //ganhou o jogo
            MsgVitoria.text = "Parabéns!";
        }
            
    }
    
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
