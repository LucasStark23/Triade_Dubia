using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Life : MonoBehaviour
{
    public Image healthBar;
    public float maxLife;

    private float currentLife;

    private void Start()
    {
        currentLife = maxLife;
        UpdateHealth();
    }
    public void TakeDamage(float damage)
    {
        currentLife -= damage;
        currentLife = Mathf.Clamp(currentLife,0,maxLife);
        UpdateHealth();


    }
    public void HealingHealth(float healing)
    {
        currentLife += healing;
        currentLife = Mathf.Min(currentLife, maxLife);
        UpdateHealth();
    }
    void UpdateHealth()
    {
        healthBar.fillAmount = currentLife / maxLife;
    }
}
