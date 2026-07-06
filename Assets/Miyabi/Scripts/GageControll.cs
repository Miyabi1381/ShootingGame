// =====================================================================================
// File: GageControll.cs
//
// Brief: ゲージの加算/減算処理を行う
//
// Author: Banno Miyabi
// Date: 2026.5.28
// =====================================================================================
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class GageControll : MonoBehaviour
{
    // 宣言
    [Tooltip("uGUI")]
    [SerializeField] private Image gaugeImage;
    [Tooltip("燃料の最大値")]
    [SerializeField] private float maxFuel = 30f;
    [Tooltip("現在の燃料の値")]
    [SerializeField] private float currentFuel = 0f;
    [Tooltip("燃料の秒間減少値")]
    [SerializeField] private float decreaseFuel_s = 1f;

    private void Awake()
    {
        // 現在の燃料を最大値にする
        currentFuel = maxFuel;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // ゲージを減らす
        DecreaseFuel();

        // Debug: スペースキーを押すと燃料が追加される
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
            IncreaseFuel(5f);

        // ゲージの値をスプライトに反映させる
        gaugeImage.fillAmount = currentFuel / maxFuel;
    }

    /**
     * @brief 燃料を減らす処理
     *
     * @param なし
     * 
     * @return なし
     */
    private void DecreaseFuel()
    {
        // 0よりも値が大きい間、毎秒燃料を指定値減少させる
        if (currentFuel > 0f)
            currentFuel -= decreaseFuel_s * Time.deltaTime;
        // 0未満になった時、プレイヤーの死亡を通知する
        //else

    }

    /**
     * @brief 燃料を増やす処理
     *
     * @param addFuel 増やす燃料量
     * 
     * @return なし
     */
    public void IncreaseFuel(float addFuel)
    {
        // 追加する燃料量が最大値を超えるとき、燃料量を最大値にする
        if (currentFuel + addFuel > maxFuel)
            currentFuel = maxFuel;
        // そうでない場合入力された値を追加
        else
            currentFuel += addFuel;
    }
}
