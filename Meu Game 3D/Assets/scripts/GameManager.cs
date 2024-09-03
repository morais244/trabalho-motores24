using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI hud, MsgVitoria;
    public int restantes;
    public AudioClip clipMoeda, clipVitoria;

    private AudioSource source;
    
    
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out source);
        restantes = FindObjectsOfType<moeda>().Length;

        hud.text = $"moedas restantes: {restantes}";
    }

    public void SubtrairMoedas(int valor)
    {
        restantes -= valor;
        hud.text = $"moedas restantes: {restantes}";
        source.PlayOneShot(clipMoeda);

        if (restantes <= 0)
        {
            //ganhou o jogo
            MsgVitoria.text = "Parabéns!";
            source.Stop();
            source.PlayOneShot(clipVitoria);
        }
            
    }
    
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
