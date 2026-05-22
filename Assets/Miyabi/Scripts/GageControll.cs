// =====================================================================================
// File: GageControll.cs
//
// Brief: ゲージの加算/減算処理を行う
//
// Author: Banno Miyabi
// Date: 2026.5.22
// =====================================================================================
using UnityEngine;
using TMPro;

public class GageControll : MonoBehaviour
{
    // 宣言
    [Tooltip("燃料の最大値")]
    [SerializeField] private float maxFuel = 30f;
    [Tooltip("現在の燃料の値")]
    [SerializeField] private float currentFuel = 30f;
    [Tooltip("燃料の秒間減少値")]
    [SerializeField] private float decreaseFuel_s = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /**
     * @brief 
     *
     * @param なし
     * 
     * @return なし
     */
    void DecreaseTimer()
    {

    }
}
