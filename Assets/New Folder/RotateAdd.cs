using NaughtyAttributes;
using UnityEngine;

public class RotateAdd : MonoBehaviour
{
    [SerializeField, Label("��]�p�x�̐ݒ�")] private int _rotateAngle = 15;
    
    [Button("���s")]
    public void RrotateAddAngle()
    {
        transform.Rotate(0, 0, -_rotateAngle);
    }
}