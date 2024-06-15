using UnityEngine;

public class Character : MonoBehaviour
{
    public string characterName;
    public int maxHealth;
    public int currentHealth;
    public int attackDamage;

    public virtual void Attack(Character target)
    {
        target.TakeDamage(attackDamage);
    }

    public virtual void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        Debug.Log(characterName + " morreu.");
        gameObject.SetActive(false); // Desativa o personagem no jogo
    }
}
