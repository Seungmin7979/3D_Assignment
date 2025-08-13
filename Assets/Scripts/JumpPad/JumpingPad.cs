using UnityEngine;

public class JumpingPad : MonoBehaviour
{
    public float jumpForce = 15; // 점프대 힘

    public void OnTriggerEnter(Collider other)
    {
        // 플레이어에 닿았는지 체크
        if (other.CompareTag("Player"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                // Y축 방향 속도를 0으로 초기화 후 위로 힘 가하기
                rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
                rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
            }
        }
    }
}
