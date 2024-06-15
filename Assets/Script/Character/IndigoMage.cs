public class IndigoMage : Character
{
    public float cooldownFocoGelido = 2f;
    private float cooldownTimerFocoGelido = 0f;

    public float cooldownCristalProtetor = 4f;
    private float cooldownTimerCristalProtetor = 0f;

    public override void Attack(Character target)
    {
        // Implementa��o do ataque normal
        base.Attack(target);
    }

    public void UseFocoGelido()
    {
        if (cooldownTimerFocoGelido <= 0)
        {
            // Implementa��o de Foco G�lido
            cooldownTimerFocoGelido = cooldownFocoGelido;
        }
    }

    public void UseCristalProtetor(Character target)
    {
        if (cooldownTimerCristalProtetor <= 0)
        {
            // Implementa��o de Cristal Protetor
            cooldownTimerCristalProtetor = cooldownCristalProtetor;
        }
    }

    protected override void Die()
    {
        base.Die();
        // Implementa��o espec�fica de morte do Mago �ndigo, se necess�rio
    }
}
