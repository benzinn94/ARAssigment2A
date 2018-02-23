using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(MeshFilter))]
[ExecuteInEditMode]
public class MeshScript : MonoBehaviour {

	Mesh mesh;
	Vector3[] vertices;
	int[] triangles;

	void Awake()
	{
		mesh = GetComponent<MeshFilter>().mesh;
	}
	// Use this for initialization
	void Start () {
		makeMeshData();
		createMesh();

	}

	// Update is called once per frame
	void Update () {

	}
	void makeMeshData()
	{//                                         0                   1                   2                   3                       4                   5                      6                    7                      8                9                       10                  11                     12                   13                      14                  15                     16                   17                     18
		vertices = new Vector3[] {new Vector3(0,0,0), new Vector3(1,1,1), new Vector3(1,0,0), new Vector3(3, 0, 0), new Vector3(3, 1, 1), new Vector3(4, 0, 0), new Vector3(3,1,4), new Vector3(1, 1, 4), new Vector3(2, 1, 5), new Vector3(4, 1, 3), new Vector3(3,1,3), new Vector3(3, 1, 2), new Vector3(4, 1, 2), new Vector3(4, 1, 1), new Vector3(0, 1, 1), new Vector3(0, 1, 2), new Vector3(0, 1, 3), new Vector3(1, 1, 2), new Vector3(1, 1, 3) };
		//vertices = new Vector3[] { new Vector3(0, 0, 0), new Vector3(1, 1, 1), new Vector3(3, 1, 1), new Vector3(4, 0, 0), new Vector3(0, 0, 0) };
		triangles = new int[] {0, 1, 2,  2, 1, 3,  3, 1, 4,  4, 5, 3,  6, 4, 1,  6, 1, 7,  6, 7, 8,  10, 6, 9,  10, 12, 11,  11, 13, 4,  7, 18, 16,  18, 17, 15,  17, 1, 14};

	}
	void createMesh()
	{
		mesh.Clear();
		mesh.vertices = vertices;
		mesh.triangles = triangles;
	}
}
