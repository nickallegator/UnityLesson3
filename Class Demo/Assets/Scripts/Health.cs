using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{

    public int health = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            OnDamage(10);
        }
    }

    public void OnDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            if (gameObject.tag == "Player")
            {
                Cursor.visible = true;
                SceneManager.LoadScene("MainMenu");
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
