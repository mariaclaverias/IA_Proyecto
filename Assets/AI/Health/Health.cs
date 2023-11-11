using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum TypeAgent { A, B, C, D, E }

public enum UnitGame
{
    Zombie,
    Soldier,
    None
}

public class Health : MonoBehaviour
{
    [Header("Image UI")]
    public Image HealthBarLocal;

    [Header("Count Health")]
    public int health;
    public int healthMax;
    public bool IsDead { get => (health <= 0); }

    [Header("AimOffset")]
    public Transform AimOffset;
    public Health HurtingMe;

    [Header("Type Agent")]
    public TypeAgent typeAgent;

    [Header("Type List Agent Allies")]
    public List<TypeAgent> typeAgentAllies = new List<TypeAgent>();
    private Coroutine HurtingMeroutine;
    public bool Importal = false;
    public UnitGame _Unity;
    public bool IsCantView;

    IEnumerator HurtingMeActive(Health enemy)
    {
        HurtingMe = enemy;
        yield return new WaitForSeconds(3);
        HurtingMe = null;
        StopCoroutine(HurtingMeroutine);
    }

    public virtual void Damage(int damage, Health enemy)
    {
        if (Importal) return;

        if (!IsDead)
        {
            if ((health - damage) > 0)
                health -= damage;
            else
                health = 0;
            UpdateHealthBarClone();
            if (enemy != null)
                HurtingMeroutine = StartCoroutine(HurtingMeActive(enemy));
        }
    }

    public void UpdateHealthBarClone()
    {
        if (HealthBarLocal != null)
        {
            float h = ((float)((float)health / (float)healthMax));
            HealthBarLocal.fillAmount = h;
        }
    }
}
