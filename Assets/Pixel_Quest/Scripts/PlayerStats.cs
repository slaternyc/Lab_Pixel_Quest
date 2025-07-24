using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public Transform respawnPoint;
    public string nextLevel = "Level 2";
    private int _coinCounter = 0;
    private int coinsInLevel = 0;
    private int _health = 3;
    public int _maxHealth = 3;
    private PlayerUIController _playerUIController;

    private void Start()
    {
        coinsInLevel = GameObject.Find("Coins").transform.childCount;
        _playerUIController = GetComponent<PlayerUIController>();
        _playerUIController.StartUp();
        _playerUIController.UpdateHealth(_health, _maxHealth);
        _playerUIController.UpdateCoin(_coinCounter + "/" + coinsInLevel);
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
                        _playerUIController.UpdateHealth(_health, _maxHealth);
                        Destroy(collision.gameObject);
                       
                        
                    }
                    break;
                }
            case "Death":
                {
                    _health--;
                    _playerUIController.UpdateHealth(_health, _maxHealth);
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
                    _playerUIController.UpdateCoin(_coinCounter + "/" + coinsInLevel);
                 Destroy(collision.gameObject);
                 break;
            }

        }
    }
}