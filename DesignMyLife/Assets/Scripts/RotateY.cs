using UnityEngine;
using System.Collections;
// 大家记得要加下面这一句代码
using Lean.Touch;

public class RotateY : MonoBehaviour
{
    Vector3 previousPosition;
    Vector3 offset;
    void Update()
    {
        // 通过LeanTouch插件，来判断目前触碰屏幕的手指数量
        // 根据我们之前的手势设计，只有在单指的情况下，才可以旋转Unity酱
        if (LeanTouch.Fingers.Count == 1)
        {

            // LeanTouch可以将鼠标点击和屏幕触碰进行转换
            if (Input.GetMouseButtonDown(0))
            {

                previousPosition = Input.mousePosition;

            }

            if (Input.GetMouseButton(0))
            {

                offset = Input.mousePosition - previousPosition;
                previousPosition = Input.mousePosition;

                if (offset.y > 0)
                {
                    transform.Rotate(Vector3.up, offset.magnitude, Space.Self);
                }

                if (offset.y < 0)
                {
                    transform.Rotate(Vector3.down, offset.magnitude, Space.Self);
                }
               

            }

        }
    }
}

