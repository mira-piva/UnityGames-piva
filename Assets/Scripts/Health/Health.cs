using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    [SerializeField] Slider healthSlider;
    [SerializeField] float maxHealth = 100f;
    Animator animator;
    [SerializeField] Movement movement;

    float currenHealth;
    bool isDead = false;   
    void Start()
    {
        currenHealth = maxHealth;

        healthSlider.minValue = 0;
        healthSlider.maxValue = maxHealth;

        UpdateHUD();

        animator = GetComponent<Animator>();

    }
    public void TakeDamege(float damage)
    {
        if (isDead) return;
        currenHealth -= damage;
        UpdateHUD();
        if (currenHealth <= 0)
        {
            Die();
        }
    }
       public  void addHeal(float heal) 
    {
         currenHealth += heal;
         UpdateHUD();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void UpdateHUD()
    { 
        healthSlider.value = currenHealth;
    }
    void Die()
    {
        isDead = true;
        Debug.Log("player is dead");
        animator.SetBool("isDead", true);
        movement.enabled = false;
    }
}


 

