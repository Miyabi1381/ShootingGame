using System;
using System.Collections;
using UnityEngine;

public class Enemy_Miyabi : EnemyBase
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

        Debug.Log("Moving");
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
        Debug.Log("Destroy");

        Destroy(gameObject);
    }

    IEnumerator Shoot()
    {

        yield return null;
    }
}
