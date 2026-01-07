using System;
using UnityEngine;
using UnityEngine.InputSystem;


public class Moverjogador : MonoBehaviour

{
    
private void OnCollisionEnter(Collision quem)
{
    if (quem.gameObject.tag == "Cubos")
    {
      som.PlayOneShot(bater);
 }
 if (quem.gameObject.tag == "moeda")
 { 
    som.PlayOneShot (moeda);
    quem.gameObject.active=false;
}
}
    public Rigidbody Cubinho;

    public AudioSource som;
    public AudioClip moeda;
    public AudioClip bater;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cubinho.AddForce(0,0,1);
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            Cubinho.AddForce(-2,0,0);
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            Cubinho.AddForce(2,0,0);
        }
}
}


