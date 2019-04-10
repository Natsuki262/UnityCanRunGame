using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Running();
    }
    void Running()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * 1.0f;
            animator.SetBool("is_running", true);
            Debug.Log("プシュッ");
        }
        else
        {
            animator.SetBool("is_running", false);
        }
        
    }
}
