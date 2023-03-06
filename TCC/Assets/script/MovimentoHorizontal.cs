using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MovimentoHorizontal : MonoBehaviour
{
    
    public float velocidade;
    public float JumpForce;
    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movimentoHorizntal = Input.GetAxisRaw("Horizontal");
        float movimentoVertical = Input.GetAxisRaw("Vertical");

        Jump();

        transform.Translate(new Vector3(1 * movimentoHorizntal, 1 * movimentoVertical, 0) * velocidade * Time.deltaTime);

    }


    //Minhas fun��es
    #region 

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
        }
    }

    #endregion
}
