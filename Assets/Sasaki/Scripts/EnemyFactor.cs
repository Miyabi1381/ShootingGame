using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    [SerializeField] EnemyBase[] enemyPrefabs;
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
        // X座標を決める
        float randomX = Random.Range(0f, 1f);
        // 画面上部の少し外側に生成する
        Vector3 spawnPos = Camera.main.ViewportToWorldPoint(new Vector3(randomX, 1.1f, 0f));
        spawnPos.z = 0.0f;

        // 生成するエネミーの番号を決定する
        int index = Random.Range(0, enemyPrefabs.Length);
        // 生成する
        Instantiate(enemyPrefabs[index], spawnPos, Quaternion.identity);
    }
}
