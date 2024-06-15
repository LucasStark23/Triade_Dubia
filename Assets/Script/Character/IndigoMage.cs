public class IndigoMage : Character
{
    public float cooldownFocoGelido = 2f;
    private float cooldownTimerFocoGelido = 0f;

    public float cooldownCristalProtetor = 4f;
    private float cooldownTimerCristalProtetor = 0f;

    public override void Attack(Character target)
    {
        // Implementação do ataque normal
        base.Attack(target);
    }

    public void UseFocoGelido()
    {
        if (cooldownTimerFocoGelido <= 0)
        {
            // Implementação de Foco Gélido
            cooldownTimerFocoGelido = cooldownFocoGelido;
        }
    }

    public void UseCristalProtetor(Character target)
    {
        if (cooldownTimerCristalProtetor <= 0)
        {
            // Implementação de Cristal Protetor
            cooldownTimerCristalProtetor = cooldownCristalProtetor;
        }
    }

    protected override void Die()
    {
        base.Die();
        // Implementação específica de morte do Mago Índigo, se necessário
    }
}
