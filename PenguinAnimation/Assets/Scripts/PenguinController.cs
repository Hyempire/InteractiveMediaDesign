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
        if (Input.GetKeyDown(KeyCode.UpArrow))        // ���⿡ "����� ���� �پ����� ���� ��" �̷��� ������ �ɵ�!
        {
            penguinAnim.SetTrigger("Swim_t");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))        // ���⿣ ��.. ���� "�� ���� ���� ��"..?
        {
            penguinAnim.SetBool("Idle_b", true);        // ���� �𸣰ڴµ� Idle�� ���ƿ� �� Ű ������ �� ��ٷ��� ��
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


// trigger�� bool�� ���� : Trigger�� �ѹ� true�� �Ǹ� �ִϸ��̼��� �������� ���� �ִϸ��̼����� ��ȯ����. bool�� ������
// �׷��� ���� ���� ������ ����� �� trigger�� �شٰ� ��. �ٵ� �� �� ����� ���̴� �� �𸣰���.
