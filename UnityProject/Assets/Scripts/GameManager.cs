
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("目前分數")]
    public int score;
    [Header("最佳分數")]
    public int bestscore;
    [Header("水管群組" )]
    public GameObject pipe;//GameObject可以存取場景上的物件也可以存取專案內的預知物

    private void AddScore(int add = 1)
    {

    }
    private void SetHightScore()
    {

    }
    private void GameOver()
    {
    }
    private void SpawnPipe()
    {
        GameObject.Instantiate(pipe);
    }
    private void Start()
    {
        SpawnPipe();
        SpawnPipe();
    }
}
