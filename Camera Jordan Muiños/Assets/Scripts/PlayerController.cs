using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int playerLives; //la vida actual del jugador
    //public  Vector3 PlayerDirection; //direccion
    public int itemHealer; //sanacion
    public int enemyDamage; //da�o
    public int playerDeshearted; //variable de corazones para restar
    public float speedPlayer; //velocidad
    // Start is called before the first frame update
    void Start()
    {
        
        //Debug.Log(playerDirection);
        //Hearts();
        Heal();
        Damage();
        //Debug.Assert(playerLives > 0, "El jugador esta vivo");
        //Debug.Assert(playerLives < 0, "El jugador esta muerto");
        if (playerLives > 0)
        {
            Debug.Log("Jugador esta vivo");
        }
        else
        {
            Debug.Log("Jugador esta muerto");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        //if (Input.GetKey(KeyCode.W))
        //{
        //    Debug.Log("Adelante");
        //    MovePlayer(Vector3.right);  
        //}

       // if (Input.GetKey(KeyCode.S))
        //{
        //    Debug.Log("Atras");
       //     MovePlayer(Vector3.left);
      //  }
        //movement();
    }


    //private void MovePlayer(Vector3 direction)
    //{
    //    transform.Translate(direction * speed * Time.deltaTime);

   // }
    /*private void Movement(Vector3 direction)
    {
        transform.Translate(PlayerDirection * speed *  Time.deltaTime);
       
    }*/

    private void Move()
    {
        float ejeHorizontal = Input.GetAxis("Horizontal");
        float ejeVertical = Input.GetAxis("Vertical");
        transform.Translate(speedPlayer * Time.deltaTime * new Vector3(ejeVertical, 0, ejeHorizontal));
    }
    void Heal()
    {
        playerLives = playerLives + itemHealer;
    }

    void Damage()
    {
        playerLives = playerLives - enemyDamage;
    }
}
