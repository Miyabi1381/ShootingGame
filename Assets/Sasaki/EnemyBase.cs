using System;
using UnityEngine;

public abstract class EnemyBase : MonoBehaviour
{
    [Header("Status")]
    // 譛螟ｧ菴灘鴨蛟､
    [SerializeField] protected int hitPoint;
    // 迴ｾ蝨ｨ縺ｮ菴灘鴨
    protected int currentHitPoint;

    [Header("Movement")]
    // 遘ｻ蜍暮溷ｺｦ
    [SerializeField] protected float moveSpeed;
    // 辯・侭
    [SerializeField] protected float fuel;
    // 辯・侭縺ｮ逋ｺ蟆・Ξ繝ｼ繝茨ｼ茨ｼ醍ｧ偵≠縺溘ｊ縺ｮ逋ｺ蟆・屓謨ｰ・・
    [SerializeField] protected float fuelFireRate;

    // 1回でも画面内に移ったか
    bool hasAppeared = false;

    protected virtual void Awake()
    {
        // 繝代Λ繝｡繝ｼ繧ｿ縺ｮ蛻晄悄蛹・
        Initialize();

        // 迴ｾ蝨ｨ縺ｮ菴灘鴨縺ｮ蛻晄悄蛹・
        currentHitPoint = hitPoint;
    }

    protected virtual void Start()
    {
        
    }

    protected virtual void Update()
    {
        // 菴灘鴨縺・莉･荳九・蝣ｴ蜷・
        if (currentHitPoint <= 0)
        {
            // 遐ｴ螢・
            Die();
        }

        // 蜍輔￥
        Move();
    }

    protected virtual void OnBecameVisible()
    {
        // 画面に映ったらtrueにする
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
    // 攻撃する
    protected abstract void Attack();
    // ダメージを受ける
    protected abstract void TakeDamage(int damage);
    // 破壊
    protected abstract void Die();
}
