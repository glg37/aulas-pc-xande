using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterStatus : MonoBehaviour, IDamageable
{
    [SerializeField] float lifeMax;
    [SerializeField] float speed;
    float life;
    

    public float LifeMax { get => lifeMax;}
    public float Speed { get => speed;}

    // Start is called before the first frame update
    void Awake()
    {
        life = LifeMax;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected abstract void Teste();//Obriga o filho a implementar 
    protected virtual void Teste2()//Permite que o filho sobrescreva
    {

    }
    public void TakeDamage(float damage)
    {
        life -= damage;
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
