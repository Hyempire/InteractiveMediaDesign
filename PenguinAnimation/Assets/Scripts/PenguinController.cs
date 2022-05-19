using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinController : MonoBehaviour
{
    private Animator penguinAnim;


    // Start is called before the first frame update
    void Start()
    {
        penguinAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))        // 여기에 "펭귄이 땅에 붙어있지 않을 때" 이런거 넣으면 될듯!
        {
            penguinAnim.SetTrigger("Swim_t");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))        // 여기엔 어.. 몰라 "땅 위에 있을 때"..?
        {
            penguinAnim.SetBool("Idle_b", true);        // 왠진 모르겠는데 Idle로 돌아올 때 키 누르고 쫌 기다려야 됨
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            penguinAnim.SetBool("Slide_b", true);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            penguinAnim.SetTrigger("Jump_t");
        }

    }
}


// trigger와 bool의 차이 : Trigger는 한번 true가 되면 애니메이션이 끝난다음 다음 애니메이션으로 전환해줌. bool은 안해줌
// 그래서 보통 점프 같은걸 재생할 땐 trigger로 준다고 함. 근데 둘 다 써봐도 차이는 잘 모르겠음.
