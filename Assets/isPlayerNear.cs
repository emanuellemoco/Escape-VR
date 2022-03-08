using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isPlayerNear : MonoBehaviour
{
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Player perto do livro
    private void OnTriggerEnter(Collider other)
    {
        canvas.SetActive(true);
    }

    // Player longe do livro
    private void OnTriggerExit(Collider other)
    {
        canvas.SetActive(false);
    }
}
