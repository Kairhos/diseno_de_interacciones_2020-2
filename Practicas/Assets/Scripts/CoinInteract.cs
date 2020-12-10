using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinInteract : MonoBehaviour {

    public Rigidbody rb;
    bool isInsideZone = false;
    public float torque;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isInsideZone){
            if(Input.GetKeyDown(KeyCode.Alpha1))
                transform.GetComponent<Renderer>().material.SetColor("_Color",Color.blue);
            else if(Input.GetKeyDown(KeyCode.Alpha2))
                transform.GetComponent<Renderer>().material.SetColor("_Color",Color.red);
        }
        
    }

    private void FixedUpdate() {
        if(isInsideZone && Input.GetKeyDown(KeyCode.Q))
            rb.AddTorque(transform.up * torque * -1f);
    }

    void Awake() {
        rb = GetComponent<Rigidbody>();    
    }

    public virtual void Interact(){
        Debug.Log("Ejecutando Interaccion...");
    }

    void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Player"))
            return;
        isInsideZone = true;
    }

    void OnTriggerExit(Collider other)
    {
        if(!other.CompareTag("Player"))
            return;
        isInsideZone = false;
    }
}
