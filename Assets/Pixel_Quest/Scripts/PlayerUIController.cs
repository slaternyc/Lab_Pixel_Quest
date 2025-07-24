using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIController : MonoBehaviour
{
    public Image heartImage;
    public TextMeshProUGUI coinText;

        public void StartUp()
        {
            heartImage = GameObject.Find("HeartImage").GetComponent<Image>();
            coinText = GameObject.Find ("CoinText").GetComponent<TextMeshProUGUI>();
        }

        public void UpdateHealth(float currentHealth, float maxHealth)
        {
            heartImage.fillAmount = currentHealth / maxHealth;
        }
        public void UpdateCoin(string newText)
        {
            coinText.text = newText;
        }


}