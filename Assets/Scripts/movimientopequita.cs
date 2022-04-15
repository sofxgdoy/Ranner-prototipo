using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientopequita : MonoBehaviour
{ 
    bool canJump;
    //declaracion de variables
    private Rigidbody2D Rigidbody2D;
    private float Horizontal;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //esta linea hace q se mueva solo constantemente
        /*gameObject.transform.position = new Vector3(gameObject.transform.position.x + 0.5f * Time.deltaTime, gameObject.transform.position.y, gameObject.transform.position.z); */
        Horizontal = Input.GetAxisRaw("Horizontal");

        ManageJump();

    }


    void ManageJump() {

        if(gameObject.transform.position.y <=0) 
        {
            canJump = true;
        }
        
        if(Input.GetKey("up") && canJump && gameObject.transform.position.y <10 ){
            
            gameObject.transform.Translate(0, 10f * Time.deltaTime, 0);
        }

        else {
            canJump = false;

            if (gameObject.transform.position.y > 0 ) {

                gameObject.transform.Translate( 0, -45f * Time.deltaTime, 0);
            }
        }
    }

    private void FixedUpdate() {
        Rigidbody2D.velocity = new Vector2(Horizontal * 3f, Rigidbody2D.velocity.y);
    }


}
