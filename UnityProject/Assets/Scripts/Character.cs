
using UnityEngine;

public class Character : MonoBehaviour
{
    [Header("跳躍高度"), Range(0, 999)]
    public int high = 999;
    [Header("是否死亡")]
    public bool dead = true;
}
