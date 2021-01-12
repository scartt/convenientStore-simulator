/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneControl : MonoBehaviour
{
    [SerializeField]
    public static int state;//0正常，1改变场景，2交互
    public static int pathPoint;//角色传送到当前场景时对应通过的路径点标记

    public List<WayPoint> list = new List<WayPoint>();//保存的当前场景中的所有传送点触发器的对象
    public Transform player;

    private void Start()
    {
        //场景初始加载，遍历当前所有触发点，找到角色在该场景的传送位置
        foreach (WayPoint point in list)
        {
            if (point.pathPoint == pathPoint && point.PointAnchor && player)
            {
                player.position = point.PointAnchor.position;
                break;
            }
        }

    }
}
*/