using UnityEngine;

public class EnemyMoveMiya : EnemyBase
{
    protected override void Attack()
    {
        throw new System.NotImplementedException();
    }

    protected override void Die()
    {
        throw new System.NotImplementedException();
    }

    protected override void Initialize()
    {

    }

    protected override void Move()
    {
        transform.position += new Vector3(moveSpeed, 0, 0);
    }

    protected override void TakeDamage(int damage)
    {
        throw new System.NotImplementedException();
    }


}
