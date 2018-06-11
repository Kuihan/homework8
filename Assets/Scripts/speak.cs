using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;

public class speak : MonoBehaviour {
    float time;
    bool inani, bigani, smallani;
    public static int num;
    // Use this for initialization
    void Start () {
        //开始过5秒开始显示
        time = 0;
        inani = false;
        this.transform.localScale = new Vector3(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        if (num - ((int)Time.time) / 16 <= 0) return;
        if ((((int)Time.time) / 16) % 2 == 0 && this.name == "Button2") return;
        if ((((int)Time.time) / 16) % 2 == 1 && this.name == "Button") return;
        time = Time.time;
        while (time > 16) time -= 16;
        if(time > 14)
        {
            small();
            if (smallani == true)
            {
                this.transform.localScale -= new Vector3(0.01f, 0.01f, 0);
                if (this.transform.localScale.x < 0.02f) smallani = false;
            }
        }
        else if(time > 5)
        {
            scrollmove();
        }
        else if(time > 3)
        {
            big();
            if (bigani == true)
            {
                this.transform.localScale += new Vector3(0.01f, 0.01f, 0);
                if (this.transform.localScale.x > 0.98f) bigani = false;
            }
        }
        
	}

    void big()
    {
        if (inani == true) return;
        scroll.read = true;
        inani = true;
        bigani = true;
    }

    void small()
    {
        if (inani == false) return;
        inani = false;
        smallani = true;
    }

    void scrollmove()
    {
        if (scroll.move == true) return;
        scroll.move = true;
    }
}
