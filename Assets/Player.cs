using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    //public rigid body

    public Rigidbody ball;
    //score
    public Text score;

    //collision on obstacle
    //public void OnCollisionEnter(Collision collision)
    //{
    //    if(Collision.gameObject.CompareTag("Respawn"))

    //      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


    //}


    //ball speed
    public float BallForce;
    // Start is called before the first frame update
    void Start()
  
        {
        
    }

    //quit game
    public void quitgame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        ball.AddForce(0f, 0f, BallForce);

        //ball control
        if (Input.GetKey("a"))
            ball.AddForce(-BallForce, 0f, 0f);

        if (Input.GetKey("d"))
            ball.AddForce(BallForce, 0f, 0f);

        score.text = ball.position.z.ToString("0");

        //game over
        if(ball.position.y<-5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        




    }
}
