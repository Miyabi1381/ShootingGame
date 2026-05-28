using System;
using UnityEngine;

public abstract class EnemyBase : MonoBehaviour
{
    [Header("Status")]
    // 最大体力値
    [SerializeField] protected int hitPoint;
    // 現在の体力
    protected int currentHitPoint;

    [Header("Movement")]
    // 移動速度
    [SerializeField] protected float moveSpeed;
    // 燃料
    [SerializeField] protected float fuel;
    // 燃料の発射レート（１秒あたりの発射回数）
    [SerializeField] protected float fuelFireRate;

    // 1回でも画面内に移ったか
    bool hasAppeared = false;

    protected virtual void Awake()
    {
        // パラメータの初期化
        Initialize();

        // 現在の体力の初期化
        currentHitPoint = hitPoint;
    }

    protected virtual void Start()
    {
        
    }

    protected virtual void Update()
    {
        // 体力が0以下の場合
        if (currentHitPoint <= 0)
        {
            // 破壊
            Die();
        }

        // 動く
        Move();
    }

    protected virtual void OnBecameVisible()
    {
        // 一度でも画面に映ったら true
        hasAppeared = true;
    }

    // 画面外に出たら
    protected virtual void OnBecameInvisible()
    {
        // まだ画面に映っていない状態で Invisible になった場合は無視
        if (!hasAppeared) return;

        // 画面に映った後で Invisible になったら破壊
        Die();
    }

    // 派生クラスで実装する処理
    // 初期化
    protected abstract void Initialize();
    // 移動
    protected abstract void Move();
    // 攻撃
    protected abstract void Attack();
    // ダメージを受ける
    protected abstract void TakeDamage(int damage);
    // 破壊
    protected abstract void Die();
}
