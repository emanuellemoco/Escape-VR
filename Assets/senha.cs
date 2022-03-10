using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class senha : MonoBehaviour
{
    public int[] resposta = {3, 4, 2, 3, 4, 1}; 
    public int[] arlist;
    int index = 0;
    public Animator bauTrigger;


    // Start is called before the first frame update
    void Start()
    {
       //bauTrigger = GetComponent<Animator>();
        arlist = new int[6];
    //    arlist = new ArrayList(); 
    //    resposta = new ArrayList();
    //    resposta.Add(3);
    //    resposta.Add(4);
    //    resposta.Add(2);
    //    resposta.Add(3);
    //    resposta.Add(4);
    //    resposta.Add(1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonPressed(int botao){
        
        
        arlist[index] = botao;
        index++;
        Debug.Log(botao);
    
        if(botao == 0){
            index = 0; 
            return;
        }
        if(index == 6){
            var acertou = true;
            Debug.Log("entrou");
            for(int i = 0 ; i < 6; i++){  
                Debug.Log("______");
                Debug.Log(arlist[i]);
                Debug.Log(resposta[i]);
                Debug.Log("______"); 
                Debug.Log(arlist[i] != resposta[i]);
                if(arlist[i] != resposta[i]){
                    Debug.Log("ERROROOO");

                    index = 0;
                      // colocar som de erro
                    // arlist = new ArrayList();
                    acertou = false;
                    return;
                     
                }
 
            }

            Debug.Log(acertou); 
            if(acertou){ 
                Debug.Log("ACERTOOO");
                bauTrigger.SetBool("ab", true);
                acertou = false;
            // som do bau abrindo
            }
        }

    }

    //ordem
    // 3 4 2 3 4 1
    // DOWN, LEFT, RIGHT, DOWN, LEFT, UP
}
