using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shovel : MonoBehaviour
    
{
    public Animator animator;
    

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    

    // Update is called once per frame
    void Update()
    {
        
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                animator.Play("piled");

                Destroy(gameObject, 1f);
            }

        }
            
    }
}
