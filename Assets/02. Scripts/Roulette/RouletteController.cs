using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed;
    public bool isStop;

    void Start()
    {
        // 시작하면 속도를 0으로 초기화
        rotSpeed = 0f;
    }
    void Update()
    {
        transform.Rotate(Vector3.forward * rotSpeed);

        // 마우스 좌클릭하면 룰렛이 돌기 시작한다.
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = 5f;
        }

        // 스페이스바를 누르면 멈추기 시작한다.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }
        
        // 속도 감소 처리
        if (isStop == true)
        {
            rotSpeed *= 0.98f; // 현재 속도에서 특정 값만큼 줄이는 기능

            // 속도가 일정 값 이하로 떨어지면 룰렛을 멈춘다.
            if (rotSpeed < 0.01f)
            {
                rotSpeed = 0f;
                isStop = false;
            }
        }
    }
}
