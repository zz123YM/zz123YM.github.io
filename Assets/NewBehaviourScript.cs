using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    // 控制旋转的速度
    public float rotationSpeed = 100f;

    // Update是每帧调用一次
    void Update()
    {
        // 让物体围绕自己的Y轴旋转
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}