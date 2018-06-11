using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Message : MonoBehaviour {
    public static List<string> MessageBox;
    private List<string> m1, m2;
    private bool flag;
    // Use this for initialization
    void Start () {
        MessageBox = new List<string>();
        m1 = new List<string>();
        m2 = new List<string>();
        init();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void init()
    {
        //网上找的对话
        m1.Add("妈，我昨晚梦见你了！ ");
        m1.Add("梦见啥了？ ");
        m1.Add("我梦见你给我二千块钱让我随便去买衣服了。 ");
        m1.Add("那你梦错了，肯定不是你亲妈！ ");

        m2.Add("妈，下个月有两个闺蜜要结婚，都请我去给他们当伴娘了！ ");
        m2.Add("那当然了，不请你请谁呀？ ");
        m2.Add("？？？ ");
        m2.Add("谁让你长得那么丑。 ");

        MessageBox = new List<string>(m1);
        flag = true;
    }

    private void OnGUI()
    {
        //按钮切换对话内容
        if (GUI.Button(new Rect(0, 0, 150, 50), "Change Message"))
        {
            if(flag)MessageBox = new List<string>(m2);
            else MessageBox = new List<string>(m1);
            flag = !flag;
            scroll.l = new List<string>(MessageBox);
            speak.num = MessageBox.Count + ((int)Time.time) / 16 + 1;
        }
    }
}
