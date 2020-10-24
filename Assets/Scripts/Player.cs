using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField]
    float _moveSpeed = 400f;

    float movement = 0f;

    void Update()
    {
      movement=   Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -_moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("die");
        //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // SceneManager.LoadScene(GameScene);
        SceneManager.LoadScene("MenuScene", LoadSceneMode.Additive);
    }
}
