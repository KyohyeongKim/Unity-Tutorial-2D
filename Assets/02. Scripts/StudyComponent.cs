using System;
using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj; // 큐브 게임오브젝트를 가져오고 싶다.

    public Mesh msh;
    public Material mat;
    
    // public Transform objTf;

    // public string changeName;

    private void Start()
    {
        /*// obj = GameObject.Find("Main Camera");
        
        // Player라는 Tag를 가진 게임오브젝트를 찾아서 obj에 할당
        obj = GameObject.FindGameObjectWithTag("Player");
        objTf = GameObject.FindGameObjectWithTag("Player").transform;
        // objTf = obj.transform;
        
        // obj의 MeshRenderer에 접근해서 활성상태를 false로 변경하겠다.
        obj.GetComponent<MeshRenderer>().enabled = false;

        Debug.Log($"<color=#FF0000>이름 : {obj.name}"); // 게임오브젝트의 이름 
        Debug.Log($"<color=#00FF00>태그 : {obj.tag}"); // 게임오브젝트의 태그
        Debug.Log($"<color=#0000FF>위치 : {obj.transform.position}"); // 게임오브젝트의 Transform 컴포넌트의 위치
        Debug.Log($"<color=#FFFF00>회전 : {obj.transform.rotation}"); // 게임오브젝트의 Transform 컴포넌트의 회전
        Debug.Log($"<color=#FF00FF>크기 : {obj.transform.localScale}"); // 게임오브젝트의 Transform 컴포넌트의 크기
        
        // MeshFilter 컴포넌트에 접근해서 mesh를 Log 메세지로 출력하는 기능
        Debug.Log($"Mesh 데이터 : {obj.transform.GetComponent<MeshFilter>().mesh}");
        
        // MeshRenderer 컴포넌트에 접근해서 material을 Log 메세지로 출력하는 기능
        Debug.Log($"Material 데이터 : {obj.transform.GetComponent<MeshRenderer>().material}");
        
        // obj의 GameObject 활성상태를 끄는 기능
        obj.SetActive(false);
        
        // obj.name = changeName;*/

        // CreateCube();
        
        obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    public void CreateCube()
    {
        // obj = new GameObject();
        // obj.name = "Cube";
        obj = new GameObject("Cube");
        
        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh;
        
        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;
        
        obj.AddComponent<BoxCollider>();
    }
}
