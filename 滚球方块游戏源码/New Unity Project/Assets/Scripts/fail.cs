using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fail : MonoBehaviour {


    //谁触发了我？

    //进入触发器范围内执行一次
    void OnTriggerEnter(Collider coll) {

        Debug.Log("Cube Enter"+coll.gameObject.name);
    }

    //离开触发器范围后执行一次
    void OnTriggerExit(Collider coll) {

        Debug.Log("Cube Exit"+coll.gameObject.name);
    }


    //进入触发器范围内持续发生的事件
    void OnTriggerStay(Collider coll) {

        Debug.Log("Cube Stay"+coll.gameObject.name);
    }


}
