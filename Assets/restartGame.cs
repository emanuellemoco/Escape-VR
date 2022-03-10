using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartGame : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("CHEGOU PERTO");
        Scene scene = SceneManager.GetActiveScene();
        
        SceneManager.LoadScene(scene.name);
    

    }
}




// TO DO
// - Musica ambiente
// - Som de baú abrindo
// - Tornar Candelabro pegáveis


// Objetos manipuláveis:
// - Setas senhas
// - Botao restar senhas
// - Pagina do livro
// - Chave
// - Porta
// - Botao restart jogo 
// - Candelabro