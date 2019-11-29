using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("目前分數")]
    public int score;
    [Header("最佳分數")]
    public int bestscore;
    [Header("水管群組")]
    public GameObject pipe;//GameObject可以存取場景上的物件也可以存取專案內的預知物
    [Header("結束畫面")]
    public GameObject goFinal;
   


    private void AddScore(int add = 1)
    {

    }
    private void SetHightScore()
    {

    }
   public void GameOver()
    {
        goFinal.SetActive(true);
    }
    private void SpawnPipe()
    {

        Vector3 pos = new Vector3(6, Random.Range(-0.7f,2f), 0);
        GameObject.Instantiate(pipe,pos,Quaternion.identity);
    }
    private void Start()
    {
        
        InvokeRepeating("SpawnPipe", 0, 1.5f);
    }
}

  
