using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    // ������ת���ٶ�
    public float rotationSpeed = 100f;

    // Update��ÿ֡����һ��
    void Update()
    {
        // ������Χ���Լ���Y����ת
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}