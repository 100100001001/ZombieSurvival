using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����� �Է¿� ���� �÷��̾� ĳ���͸� �����̴� ��ũ��Ʈ
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;      // �յ� �������� �ӵ�
    public float rotateSpeed = 180f;  // �¿� ȸ�� �ӵ�

    private PlayerInput playerInput;  // �÷��̾� �Է��� �˷��ִ� ������Ʈ
    [SerializeField] private Rigidbody PlayerRigidbody; // �÷��̾� ĳ������ ������ٵ�
    private Animator PlayerAnimator; // �÷��̾� ĳ������ �ִϸ�����

    private void Start()
    {
        // ����� ������Ʈ���� ���� ��������
        playerInput = GetComponent<PlayerInput>();
        PlayerRigidbody = GetComponent<Rigidbody>();
        PlayerAnimator = GetComponent<Animator>();
    }

    // FixedUpdate�� ���� ���� �ֱ⿡ ���� �����
    private void FixedUpdate()
    {
        // ���� ���� �ֱ⸶�� ������, ȸ��, �ִϸ��̼� ó�� ����
    }

    // �Է°��� ���� ĳ���͸� �յڷ� ������
    private void Move()
    {

    }

    // �Է°��� ���� ĳ���͸� �¿�� ȸ��
    private void Rotate()
    {

    }

}
