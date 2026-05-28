using UnityEngine;

public class EnemyFactor
{
    [SerializeField] GameObject[] enemyPrefabs;
    [SerializeField] float spawnInterval = 2.0f;

    float timer;

    void Update()
    {
        // カウントを進める
        timer += Time.deltaTime;

        // 一定時間経過したら
        if(timer > spawnInterval)
        {
            // エネミーを生成する
            SpawnEnemy();
            // タイマーを初期化する
            timer = 0;
        }
    }

    void SpawnEnemy()
    {
        // 生成するエネミーの番号を決定する
        int index = Random.Range(0, enemyPrefabs.Length);

        // 生成する

    }
}
