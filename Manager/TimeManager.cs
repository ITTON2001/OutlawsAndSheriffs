using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public DateTime startTime = new DateTime(1880, 1, 1, 0, 0, 0);
    public TMP_Text timeText;

    private bool isStop = false;
    private float countSpeed = 10.0f;
    private double elapsedGameMinutes = 0.0;

    void Update()
    {
        if (!isStop)
        {
            // ゲーム内経過時間を積み上げていく
            elapsedGameMinutes += Time.deltaTime * countSpeed;
        }

        // 現在のゲーム内時刻
        DateTime currentTime = startTime.AddMinutes(elapsedGameMinutes);

        if (timeText != null)
        {
            timeText.text = currentTime.ToString("yyyy/MM/dd HH:mm");
        }
    }

    // ボタン関数（速度変更）
    public void pushDoubleButton() => countSpeed = 20.0f;
    public void pushQuadrupleButton() => countSpeed = 40.0f;
    public void pushNormalButton() => countSpeed = 10.0f;
    public void pushStopButton() => isStop = !isStop;
    public void pushSlowButton() => countSpeed = 5.0f;
}
