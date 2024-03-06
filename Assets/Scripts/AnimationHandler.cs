using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator m_Animator;
    void Start()
    {
        m_Animator = GetComponent<Animator>();
        //print("ini start");
    }

    // Update is called once per frame
    void Update()
    {
        //print("ini update");
        if (Input.GetKey(KeyCode.Space))
        {
            //print("ini spasi diklik!");
            m_Animator.SetTrigger("goAttack");
        }
    }
}
