using UnityEngine;

public class StudyMaterial : MonoBehaviour
{
    public Material mat;

    public string hexCode;

    void Start()
    {
        // this.GetComponent<Material>() = mat; // Material을 바꾸는 방식 X
        
        // this.GetComponent<MeshRenderer>().sharedMaterial = mat; // MeshRenderer에 접근해서 바꾸는 방식
        
        // this.GetComponent<MeshRenderer>().material.color = Color.green;
        
        // this.GetComponent<MeshRenderer>().sharedMaterial.color = Color.green;
        
        this.GetComponent<MeshRenderer>().material.color = new Color(200f/255f, 137f-255f, 70f-255f, 1);
        
        mat = this.gameObject.GetComponent<MeshRenderer>().material;
        Color outputColor;

        if (ColorUtility.TryParseHtmlString(hexCode, out outputColor))
        {
            mat.color = outputColor;
        }
    }

    // 대각선 이동이 불가능하므로 잘못된 조건
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            // 앞으로 가는 기능
        }
        else if (Input.GetKey(KeyCode.A))
        {
            // 왼쪽으로 가는 기능
        }
        else if (Input.GetKey(KeyCode.S))
        {
            // 뒤로 가는 기능
        }
        else if (Input.GetKey(KeyCode.D))
        {
            // 오른쪽으로 가는 기능
        }
    }
}
