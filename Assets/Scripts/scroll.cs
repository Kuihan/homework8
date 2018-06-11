using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scroll : MonoBehaviour {
    public static bool move, read;
    public static List<string> l;
    public static int count;
    private Text t;
    private int framecount;
    private string str;
    public int maxLength = 10;          //滚动时单行最大字数
	// Use this for initialization
	void Start () {
        move = false;
        read = false;
        framecount = -1;
        t = GetComponent<Text>();
        t.text = "message";
        l = new List<string>(Message.MessageBox);
        count = l.Count;
        speak.num = count;
	}
	
	// Update is called once per frame
	void Update () {
        if (read) reading();
        if (move == false) return;
        //每次只读一条
        if(str.Length <= maxLength)
        {
            move = false;
            framecount = -1;
        }
        else
        {
            if (framecount < 0) framecount = 0;
            if(framecount == 10)
            {
                t.text = str.Remove(maxLength, str.Length - maxLength);
                str = str.Remove(0, 1);
                framecount = 0;
            }
            ++framecount;
        }
	}

    void reading()
    {
        t.text = l[0];
        str = l[0];
        l.RemoveRange(0, 1);
        read = false;
    }
}
