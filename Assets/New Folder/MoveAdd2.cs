using NaughtyAttributes;
using UnityEngine;

public class MoveAdd�Q : MonoBehaviour
{
    [SerializeField, Label("�����̐ݒ�")] private int _step = 10;

    [Button("���s")]
    public�@void MoveAddPosition()
    {
        transform.position += transform.right * _step / 100f;
    }
}
