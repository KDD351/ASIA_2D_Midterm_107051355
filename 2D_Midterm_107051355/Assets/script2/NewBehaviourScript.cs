
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
         // 註解 : 說明
         // 按鈕如何跟程式溝通
         // 需要 : 方法 (函式、功能) - 一堆有功能的程式，演算法
         // 語法 :
         // 修飾詞 類型 方法名稱 () {}
         // 私人 private (預設) - 不可被按鈕呼叫
         // 公開 public - 可以被按鈕呼叫
         // void 無類型
         public void StartGame()
        {
        print("開始遊戲");
        SceneManager.LoadScene("關卡1");
        }

        public void QuitGame()
        {
        print("離開遊戲");
        Application.Quit();
        }
}
