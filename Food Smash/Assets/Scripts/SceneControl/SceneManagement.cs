/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//玩家传送触发器及传送点
public class StreetChanger : MonoBehaviour
{

    public string sceneName;//传送的场景的名字
    public float transTime;//传送等待的时间，比如在此时间内让场景屏幕变黑，有过渡感
    private bool locked = true;//自加锁，保证同一个场景中的多个传送器只有一个运行
    public int pathPoint;//表示和场景中的哪个点相对应，所对应的点在目标场景的SceneControl中

    // Update is called once per frame
    void Update()
    {
        if (SceneControl.state == 1 && !locked)
        {//当场景信息的状态为1表示当前进入传送状态，locked表示传送点数据有当前的StreetChanger来传送
            transTime -= Time.deltaTime;
            if (transTime <= 0) SceneManager.LoadScene(sceneName);
        }

    }

    //如果进入触发区域的对象为玩家，并且按下I键，场景处于空闲状态，那么进行传送过程
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player") && Input.GetKeyDown(KeyCode.I) && SceneControl.state == 0)
        {
            SceneControl.state = 1;
            SceneControl.pathPoint = pathPoint;
            locked = false;
        }
    }
}


//场景控制器，用于控制场景中的一些通用信息的类

*/