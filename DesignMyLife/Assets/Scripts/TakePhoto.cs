using UnityEngine;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
public class TakePhoto : MonoBehaviour
{
    string Path_save;
    public GameObject DisUi;
    void Start()
    {
        
    }
   public void back()
    {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #else
            Application.Quit();
            #endif
    }
    public void OnGGGS()
    {    //判断是否为Android平台  
        
        System.DateTime now = System.DateTime.Now;
        string times = now.ToString();
        times = times.Trim();
        times = times.Replace("/", "-");
        string filename = "Screenshot" + times + ".png";
        
        if (Application.platform == RuntimePlatform.Android)
        {
           
            //截取屏幕  
            Texture2D texture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
            texture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
            texture.Apply();
            
            //转为字节数组  
            byte[] bytes = texture.EncodeToPNG();

            string destination = "sdcard/DCIM/DesignMyLife";
            //判断目录是否存在，不存在则会创建目录  
            if (!Directory.Exists(destination))
            {
                Directory.CreateDirectory(destination);
            }
            Path_save = destination + "/" + filename;
            //存图片  
            System.IO.File.WriteAllBytes(Path_save, bytes);
            
        }
       
    }
    public void TurnOnUI()
    {
        DisUi.GetComponent<CanvasGroup>().alpha = 1;
        DisUi.GetComponent<CanvasGroup>().interactable = true;
        DisUi.GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
    public void InvokPai()
    {
        DisUi.GetComponent<CanvasGroup>().alpha = 0;
        DisUi.GetComponent<CanvasGroup>().interactable = false;
        DisUi.GetComponent<CanvasGroup>().blocksRaycasts = false;
        Invoke("TurnOnUI", 2f);
        Invoke("OnGGGS", 1f);
    }


}
