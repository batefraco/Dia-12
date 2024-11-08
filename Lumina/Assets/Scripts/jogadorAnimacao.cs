using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jogadorAnimacao : MonoBehaviour
{
    [SerializeField] private Animator JogadorAnim;

    private Rigidbody2D jogadorrb;

    // Start is called before the first frame update
    void Start()
    {
        jogadorrb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveAnim();
    }

    void MoveAnim()
    {
        JogadorAnim.SetFloat("HorizontalAnim", jogadorrb.velocity.x);
    }
}
