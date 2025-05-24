using UnityEngine;

public class TurretController : MonoBehaviour
{
    public Transform targetTf;
    public Transform turretHead;
    
    public GameObject bulletPrefab;
    public Transform firePos;

    public float timer;
    public float cooldownTime;
    
    void Start()
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        turretHead.LookAt(targetTf);
        
        timer += Time.deltaTime;
        if (timer >= cooldownTime)
        {
            timer = 0;
            Instantiate(bulletPrefab, firePos.position, firePos.rotation); // 총알 생성
        }
    }
}
