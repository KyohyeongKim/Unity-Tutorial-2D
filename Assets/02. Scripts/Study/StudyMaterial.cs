using UnityEngine;

public class StudyMaterial : MonoBehaviour
{
    public Material mat;
    public string hexCode;

    void Start()
    {
        // this.GetComponent<Material>() = mat; // Material을 이런 식으로는 바꿀 수 없다. (오류)
        
        this.GetComponent<MeshRenderer>().material = mat; // MeshRenderer에 접근해서 바꾸는 방식
        this.GetComponent<MeshRenderer>().sharedMaterial = mat; // MeshRenderer에 접근해서 바꾸는 방식
        
        this.GetComponent<MeshRenderer>().material.color = Color.green;
        // 매터리얼 원본의 색상을 바꾼다. 따라서 동일한 매터리얼을 사용하는 모든 오브젝트의 색상이 바뀐다.
        this.GetComponent<MeshRenderer>().sharedMaterial.color = Color.green; 
        
        // 수치값으로 색상 지정
        this.GetComponent<MeshRenderer>().material.color = new Color(200f/255f, 137f-255f, 70f-255f, 1);
        
        // 헥스코드값으로 색상 지정
        mat = this.gameObject.GetComponent<MeshRenderer>().material;
        Color outputColor;

        if (ColorUtility.TryParseHtmlString(hexCode, out outputColor))
        {
            mat.color = outputColor;
        }
    }
}
