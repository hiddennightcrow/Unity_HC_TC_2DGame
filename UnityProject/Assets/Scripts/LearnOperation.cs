
using UnityEngine;

public class LearnOperation : MonoBehaviour
{
    public int a = 10, b = 5;
    public int c = 20, d = 30;
    private void Start()
    {
        #region 數學運算子
        print(a - b);
        print(a + b);
        print(a * b);
        print(a / b);
        print(a % b);

        a = a + 1;//先從右邊執行再傳到左邊的a
        print(a);//顯示a
        print(a++);//先輸出a在做++的動作
        print(++a);//先做++在輸出a


        print(a > b);//true
        print(a < b);//false
        print(a >= b);//true

        print(true && true);//true
        print(false && true);//false
        print(true && false);//false
        print(false && false);//false

        print(true || true);//true
        print(true || false);//true
        print(false || true);//true
        print(false || false);//false
        #endregion
    }
}
