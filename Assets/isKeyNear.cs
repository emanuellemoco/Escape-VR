using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isKeyNear : MonoBehaviour
{

        public Animator PortaDireitaTrigger;
        public Animator PortaEsquerdaTrigger;
        [SerializeField] private AudioSource audioPortaEs;
        [SerializeField] private AudioSource audioPortaDi;
        //public GameObject Key;



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
        if(other.gameObject.tag == "key_collider"){
            PortaDireitaTrigger.SetBool("ab", true);
            audioPortaDi.Play();
            PortaEsquerdaTrigger.SetBool("ab", true);
            audioPortaEs.Play();
        }
    


    }



}
