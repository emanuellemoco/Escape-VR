using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class senha : MonoBehaviour
{
    public ArrayList arlist; 
    public ArrayList resposta; 
    public Animator bauTrigger;


    // Start is called before the first frame update
    void Start()
    {
       //bauTrigger = GetComponent<Animator>();

       arlist = new ArrayList(); 
       resposta = new ArrayList();
       resposta.Add(3);
       resposta.Add(4);
       resposta.Add(2);
       resposta.Add(3);
       resposta.Add(4);
       resposta.Add(1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonPressed(int botao){
        arlist.Add(botao);

        if(botao == 0){
            arlist = new ArrayList(); 
            bauTrigger.SetBool("ab", true); // APAGAR DEPOISSSS
        }
        if(arlist.Count == 6){
            for(int i = 0 ; i < arlist.Count; i++){  
                if(arlist[i] != resposta[i]){
                    Debug.Log("ERROROOO");
                    // colocar som de erro
                    arlist = new ArrayList();  
                    break;
                }

            }
            Debug.Log("ACERTOOO");
            bauTrigger.SetBool("ab", true);
            // som do bau abrindo


        }

    }

    //ordem
    // 3 4 2 3 4 1
    // DOWN, LEFT, RIGHT, DOWN, LEFT, UP
}
