using System;
using UnityEngine;

public class Enemy_Sasaki : EnemyBase
{
    protected override void Initialize()
    {
        // HPの初期化
        hitPoint = 50;

        // 移動速度の初期化
        moveSpeed = 5.0f;

        // 燃料の初期化
        fuel = 5.0f;
    }

    protected override void Move()
    {
        // 画面下方向に一直線に移動する
        transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);


    }

    protected override void Attack()
    {

    }

    protected override void TakeDamage(int damage)
    {
        // ダメージを受ける
        currentHitPoint -= damage;
    }

    protected override void Die()
    {
        Destroy(gameObject);
    }

    // 画面外に出たら
    private void OnBecameInvisible()
    {
        // 破壊
        Die();
    }
}
