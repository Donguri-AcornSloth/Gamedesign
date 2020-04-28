using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveX : MonoBehaviour
{
    public float length = 4.0f;     //移動する振幅
    public float speed = 1.0f;      //移動スピード　大きくすると早くなります
    private Vector3 startPos;       //ゲーム開始時にいたポジションを入れる変数
    private float radian;　　　　//浮動小数点型の変数radianを用意します

    void Start()
    {
        startPos = transform.position; 　　//ゲーム開始時のポジションを変数startPosに取得します
        radian = 0f;	　　	　　　//開始時の回転角度はO です（開始ポジションから移動し始めます）
    }

    void FixedUpdate()
    {
        //Mathfは数学関数です、時間の経過をフレームごとにSin()の値（x軸方向の大きさ）を出して、振幅を掛けたものをx座標に加えます
        radian = Time.time * speed;
        transform.position = new Vector3(startPos.x + length * Mathf.Sin(radian), startPos.y, startPos.z);
        //transform.position = new Vector3( Mathf.PingPong(Time.time*speed,length) ,startPos.y ,startPos.z); 
        //PingPongというメソッドも使えます
    }
}
