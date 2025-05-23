using UnityEngine;
 
public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;
     
    private void Update()
    {
        /// Input System (Old - Legacy)
        /// 입력값에 대한 약속된 시스템
        /// 이동 -> WASD, 화살표키보드
        /// 점프 -> Space
        /// 총쏘기 -> 마우스 왼쪽
        
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        
        // float h = Input.GetAxisRaw("Horizontal");
        // float v = Input.GetAxisRaw("Vertical");
        
        Vector3 dir = new Vector3(h, 0, v);
        
        Vector3 normalDir = dir.normalized; // 정규화 과정 (0~1)
        Debug.Log($"현재 입력 : {normalDir}");
        
        transform.position += normalDir * moveSpeed * Time.deltaTime;
        
        transform.LookAt(transform.position + normalDir);

        // if (Input.GetKey(KeyCode.W)) // 앞으로 가는 기능
        // {
        //     transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        // }
        //  
        // if (Input.GetKey(KeyCode.S)) // 뒤로 가는 기능
        // {
        //     transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        // }
        //  
        // if (Input.GetKey(KeyCode.A)) // 왼쪽으로 가는 기능
        // {
        //     transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        // }
        //  
        // if (Input.GetKey(KeyCode.D)) // 오른쪽으로 가는 기능
        // {
        //     transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        // }
    }
}