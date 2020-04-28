using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{


    public float angle = 40.0f;     //回転するスピードです

    void FixedUpdate()
    {
        transform.Rotate(Vector3.up, angle * Time.deltaTime, Space.World);
        //オブジェクトのup（y軸）の周りに、指定されたスピードで、フレーム間の長さ分（Time.DeltaTime） 角度を足していきます、　　//ワールド座標で回します
    }

}
