using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class senha : MonoBehaviour
{
    public int[] resposta = {3, 4, 2, 3, 4, 1}; 
    public int[] arlist;
    int index = 0;
    public Animator bauTrigger;
    [SerializeField] private AudioSource audioAcerto;
    [SerializeField] private AudioSource audioErro;
    bool acertou = false;


    // Start is called before the first frame update
    void Start()
    {
       //bauTrigger = GetComponent<Animator>();
        arlist = new int[6];


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonPressed(int botao){
        if(acertou) return;
        
        
        arlist[index] = botao;
        index++;
        Debug.Log(botao);
    
        if(botao == 0){
            index = 0; 
            return;
        }
        if(index == 6){
            for(int i = 0 ; i < 6; i++){  
               if(arlist[i] != resposta[i]){
                    Debug.Log("errou");
                    index = 0;
                    audioErro.Play();
                    // arlist = new ArrayList();
                    acertou = false;
                    return;
                     
                }
 
            }

            Debug.Log(acertou); 
            Debug.Log("ACERTOOO");
            bauTrigger.SetBool("ab", true);
            audioAcerto.Play();
            acertou = true;
        // som do bau abrindo
        }

    }

    //ordem
    // 3 4 2 3 4 1
    // DOWN, LEFT, RIGHT, DOWN, LEFT, UP
}
