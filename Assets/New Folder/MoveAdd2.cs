using NaughtyAttributes;
using UnityEngine;

public class MoveAdd‚Q : MonoBehaviour
{
    [SerializeField, Label("•à”‚Ìİ’è")] private int _step = 10;

    [Button("Às")]
    public@void MoveAddPosition()
    {
        transform.position += transform.right * _step / 100f;
    }
}
