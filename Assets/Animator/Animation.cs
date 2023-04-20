using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Animation : MonoBehaviour
{
    public GameObject player;

    public Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d"))
            anim.Play("Walk");
        
        if (Input.GetKeyDown("a"))           
            anim.Play("Walk");
        
        if (Input.GetKeyDown("w"))
            anim.Play("Jump");
        
        if (Input.GetKeyDown("space")) 
            anim.Play("Run");
        
        if (Input.GetKeyDown("s")) 
            anim.Play("Idle");         
    }                                        
}














































