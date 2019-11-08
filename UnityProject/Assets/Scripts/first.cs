using UnityEngine;//使用UnityAPI

public class first : MonoBehaviour
{
    [Header("金錢"),Range(0,999)]
    public int coin=999;
   [Range(0,2)]
    public float speed=1.5f;
    [Tooltip("喝的是紅色藥水")]
    public string fj="";
    public bool dead=true;

    //事件:在特定時間點所做的事
    //開始:在每次開始遊戲時就會觸發一次的事件(此為unity內建API)
    private void Start()
    {
        print("hallo world");
    }
    //更新:一秒跑60次
    private void Update()
    {
        print("play");
    }
}
