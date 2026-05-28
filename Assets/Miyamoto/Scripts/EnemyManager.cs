using Unity.VisualScripting;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //敵のプレハブ
    [SerializeField] GameObject m_enemyPrefab;

    //生成間隔
    private const float INTERVAL = 3;


    //経過時間
    private float m_time = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        m_time += Time.deltaTime;

        //
        if(m_time>INTERVAL)
        {
            GameObject enemy = Instantiate(m_enemyPrefab);


            enemy.transform.position = new Vector3(5, Random.Range(-4, 4), 0);

            m_time = 0f;
        }
    }
}
