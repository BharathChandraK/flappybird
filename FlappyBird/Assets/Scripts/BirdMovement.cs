using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BirdMovement : MonoBehaviour
{
    Rigidbody rd;

    int score = 0;

    public Text scoreText;

    private void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rd.AddForce(0, 6, 0, ForceMode.Impulse);
            Debug.Log(score);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obsticle")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "score")
        {
            score++;
            scoreText.text = " Score :" + score.ToString();
            Debug.Log(score);
        }
    }

}
