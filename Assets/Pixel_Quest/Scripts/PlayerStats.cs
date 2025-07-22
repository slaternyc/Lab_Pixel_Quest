using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public Transform respawnPoint;
    public string nextLevel = "Level 2";
    private int _coinCounter = 0;
    private int _health = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }


  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Finish":

                {
                    string nextLevel = collision.transform.GetComponent<LevelGoal>().nextLevel;
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
            case "Health":
                {
                    if (_health < 3)
                    {
                        _health++;
                        Destroy(collision.gameObject);
                        
                    }
                    break;
                }
            case "Death":
                {
                    _health--;
                    if (_health <= 0)
                    {
                        string thisLevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(thisLevel);
                    }
                    else
                    {
                        transform.position = respawnPoint.position;
                    }
                    break;
                }
            case "Respawn":
                {
                    respawnPoint.position = collision.transform.Find("Point").position;
                    break;
                }
            case "Coin":
            {
                 _coinCounter++;
                 Destroy(collision.gameObject);
                 break;
            }

        }
    }
}