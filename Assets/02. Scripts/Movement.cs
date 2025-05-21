using UnityEngine;
 
public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;
     
    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) // 앞으로 가는 기능
        {
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }
         
        if (Input.GetKey(KeyCode.S)) // 뒤로 가는 기능
        {
            transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        }
         
        if (Input.GetKey(KeyCode.A)) // 왼쪽으로 가는 기능
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
         
        if (Input.GetKey(KeyCode.D)) // 오른쪽으로 가는 기능
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
    }
}