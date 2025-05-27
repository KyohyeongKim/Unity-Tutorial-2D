using UnityEngine;

public class StudyTransform : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 70f;

    void Update()
    {
        // // 월드 방향으로 이동
        // transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        //
        // // 로컬 방향으로 이동
        // transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime); // Space.Self 생략
        //
        // // 월드 방향으로 이동
        // transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);
        
        // 월드 방향으로 회전
        float angle = transform.eulerAngles.y + rotateSpeed * Time.deltaTime;
        float localX  = transform.eulerAngles.x;
        float localZ = transform.eulerAngles.z;
        transform.rotation = Quaternion.Euler(localX, angle, localZ);
        
        // // 월드 방향으로 회전
        // transform.rotation = Quaternion.Euler(0f, transform.eulerAngles.y + rotateSpeed * Time.deltaTime, 0f);
        //
        // // 로컬 방향으로 회전
        // transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); // Space.Self 생략
        //
        // // 월드 방향으로 회전
        // transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);
        //
        // // 특정 위치의 주변을 회전
        // transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime);
        //
        // // 특정 위치를 바라보기 위해 회전
        // transform.LookAt(Vector3.zero);
        //
        // transform.rotation *= Quaternion.Euler(Vector3.up * rotateSpeed * Time.deltaTime);
    }
}
