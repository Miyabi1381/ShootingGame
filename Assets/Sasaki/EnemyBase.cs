using UnityEngine;

public abstract class EnemyBase : MonoBehaviour
{
    [Header("Status")]
    [SerializeField] protected int hitPoint;
    protected int currentHitPoint;

    [Header("Movement")]
    [SerializeField] protected float moveSpeed;
    [SerializeField] protected float fuel;

    protected virtual void Awake()
    {
        currentHitPoint = hitPoint;
    }

    protected virtual void Start()
    {
        
    }

    protected virtual void Update()
    {
        Move();
    }

    // ”h¶ƒNƒ‰ƒX‚ÅÀ‘•‚·‚éˆ—
    // ˆÚ“®
    protected abstract void Move();
    // UŒ‚
    protected abstract void Attack();
    // ”j‰ó
    protected abstract void Die();
}
