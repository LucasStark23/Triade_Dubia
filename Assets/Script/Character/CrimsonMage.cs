public class CrimsonMage : Character
{
    public float cooldownNox = 2f;
    private float cooldownTimerNox = 0f;

    public float cooldownNoxZero = 4f;
    private float cooldownTimerNoxZero = 0f;

    public override void Attack(Character target)
    {
        // Implementa��o do ataque normal
        base.Attack(target);
    }

    public void UseNox(Character target)
    {
        if (cooldownTimerNox <= 0)
        {
            target.TakeDamage(4);
            cooldownTimerNox = cooldownNox;
        }
    }

    public void UseNoxZero(Character target)
    {
        if (cooldownTimerNoxZero <= 0)
        {
            // Implementa��o de Nox Zero (afeta o alvo e adjacentes)
            cooldownTimerNoxZero = cooldownNoxZero;
        }
    }

    protected override void Die()
    {
        base.Die();
        // Implementa��o espec�fica de morte do Mago Carmesim, se necess�rio
    }
}
