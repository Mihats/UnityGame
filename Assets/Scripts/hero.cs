using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class hero : MonoBehaviour
{
     public Rigidbody2D rb2d;
        public float playerSpeed;
        public float jumpPower;
        public int directionInput;
        public bool groundCheck;


        public void Start()
        {
            rb2d = GetComponent<Rigidbody2D>();
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize("4014701", false);
        }
    }


        public void Update()
        {
            groundCheck = true;
        }

        public void FixedUpdate()
        {
            rb2d.velocity = new Vector2(playerSpeed * directionInput, rb2d.velocity.y);
        }

        public void Move(int InputAxis)
        {
            directionInput = InputAxis;
        }

        public void Jump(bool isJump)
        {
            isJump = groundCheck;

            if (groundCheck)
            {
                rb2d.velocity = new Vector2(rb2d.velocity.x, jumpPower);
            }
        }
        public void OnTriggerEnter2D(Collider2D coll){
        Scene scene = SceneManager.GetActiveScene();
        if (coll.gameObject.tag == "Finish")
            {
            if (Advertisement.IsReady())
            {
                Advertisement.Show("Interstitial_Android");
            }
            if (scene.name == "scene1") SceneManager.LoadScene("scene2");
            if (scene.name == "scene2") SceneManager.LoadScene("scene3");
            if (scene.name == "scene3") SceneManager.LoadScene("scene1");
        }
        }
}
