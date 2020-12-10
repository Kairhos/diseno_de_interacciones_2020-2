using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    bool isInsideZone = false;

    public virtual void Interact()
    {
        Debug.Log("Ejecutando interaccion");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isInsideZone && Input.GetKeyDown(KeyCode.Q))
        {
            Interact();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Player"))
            return;

        //Debug.Log("Traspaso la esfera: " + other.gameObject.name);
        isInsideZone = true;
    }

    void OnTriggerExit(Collider other)
    {
        if(!other.CompareTag("Player"))
            return;

        //Debug.Log("Traspaso la esfera: " + other.gameObject.name);
        isInsideZone = false;
    }
}
