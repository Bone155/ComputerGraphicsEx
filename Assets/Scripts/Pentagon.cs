using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pentagon : MonoBehaviour
{
    Mesh customMesh;
    // Start is called before the first frame update
    void Start()
    {
        var mesh = new Mesh();

        var verts = new Vector3[5];

        verts[0] = new Vector3(0, 0, 0);
        verts[1] = new Vector3(0, 1, 0);
        verts[2] = new Vector3(1, 0, 0);
        verts[3] = new Vector3(1, 1, 0);
        verts[4] = new Vector3(0.5f, 1.5f, 0);
        mesh.vertices = verts;

        var indices = new int[9];

        indices[0] = 0;
        indices[1] = 1;
        indices[2] = 2;
        indices[3] = 1;
        indices[4] = 4;
        indices[5] = 3;
        indices[6] = 3;
        indices[7] = 2;
        indices[8] = 1;

        mesh.triangles = indices;

        var norms = new Vector3[5];

        norms[0] = -Vector3.forward;
        norms[1] = -Vector3.forward;
        norms[2] = -Vector3.forward;
        norms[3] = -Vector3.forward;
        norms[4] = -Vector3.forward;

        mesh.normals = norms;

        var UVs = new Vector2[5];

        UVs[0] = new Vector2(0, 0);
        UVs[1] = new Vector2(0, 1);
        UVs[2] = new Vector2(1, 0);
        UVs[3] = new Vector2(1, 1);
        UVs[4] = new Vector2(0.5f, 1.5f);

        mesh.uv = UVs;

        var filter = GetComponent<MeshFilter>();
        filter.mesh = mesh;
        customMesh = mesh;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDestroy()
    {
        if (customMesh != null)
        {
            Destroy(customMesh);
        }
    }
}
