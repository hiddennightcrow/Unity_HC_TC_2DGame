
using UnityEngine;

public class Floor : MonoBehaviour
{
    [Header("速度") ,Range(0f, 10f)]
    public float speed =1.5f;
    public Transform floor;
    private void Update()
    {
        Move();
    }
    private void Move()
    {
        floor.Translate(-speed*Time.deltaTime, 0, 0);
        
    }
}
