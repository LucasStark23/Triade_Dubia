public class NaturalCleric : Character
{
    public float cooldownVivaPorMim = 2f;
    private float cooldownTimerVivaPorMim = 0f;

    public float cooldownMorramPorEles = 2f;
    private float cooldownTimerMorramPorEles = 0f;

    public float cooldownTrocaDaDor = 2f;
    private float cooldownTimerTrocaDaDor = 0f;

    public override void Attack(Character target)
    {
        // Implementa��o do ataque normal
        base.Attack(target);
    }

    public void UseVivaPorMim(Character ally)
    {
        if (cooldownTimerVivaPorMim <= 0)
        {
            // Implementa��o de Viva Por Mim (cura um aliado)
            cooldownTimerVivaPorMim = cooldownVivaPorMim;
        }
    }

    public void UseMorramPorEles(Character ally)
    {
        if (cooldownTimerMorramPorEles <= 0)
        {
            // Implementa��o de Morram Por Eles (aumenta dano de um aliado)
            cooldownTimerMorramPorEles = cooldownMorramPorEles;
        }
    }

    public void UseTrocaDaDor(Character ally1, Character ally2)
    {
        if (cooldownTimerTrocaDaDor <= 0)
        {
            // Implementa��o de Troca da Dor (troca vida entre aliados)
            cooldownTimerTrocaDaDor = cooldownTrocaDaDor;
        }
    }

    protected override void Die()
    {
        base.Die();
        // Implementa��o espec�fica de morte do Cl�rigo Natural, se necess�rio
    }
}
