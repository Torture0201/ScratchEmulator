using NaughtyAttributes;
using UnityEngine;

public class RotateAdd : MonoBehaviour
{
    [SerializeField, Label("‰ñ“]Šp“x‚Ìİ’è")] private int _rotateAngle = 15;
    
    [Button("Às")]
    public void RrotateAddAngle()
    {
        transform.Rotate(0, 0, -_rotateAngle);
    }
}