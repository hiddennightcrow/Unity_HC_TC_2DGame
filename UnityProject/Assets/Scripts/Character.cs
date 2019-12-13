
using UnityEngine;

public class Character : MonoBehaviour
{
    [Header("跳躍高度"), Range(0, 999)]
    public int high = 100;
    [Header("旋轉角度")]
    public float angle = 5;
    [Header("是否死亡")]
    public bool dead;

    public GameObject goScore, goGM;
    public Rigidbody2D r2d;//2D剛體

    public GameManager gm;
    private void Update()
    {
        Jump();
    }
    //碰撞開始事件:物件碰撞開始執行一次
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.name);
        Dead();
    }
    //觸發開始事件:碰撞開始事件:物件碰撞開始執行一次
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "水管" || collision.gameObject.name == "水管 (1)")
        {
            Dead();

        }
     }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "通過")
        {
            gm.AddScore();

        }
    }
    private void Jump()
    {
        if (dead) return;
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            goScore.SetActive(true);
            goGM.SetActive(true);


            r2d.Sleep();
            r2d.gravityScale = 1;//2d 剛體.地心引力            
            r2d.AddForce(new Vector2(0,high));//剛體.推力(二維向量)
        }
        r2d.SetRotation(5*r2d.velocity.y);
        //print(r2d.velocity);
    }
    private void Dead()
    {
        dead = true;
        gm.GameOver();

        Floor.speed = 0;
    }
    private void PassPipe()
    {
    }
}
