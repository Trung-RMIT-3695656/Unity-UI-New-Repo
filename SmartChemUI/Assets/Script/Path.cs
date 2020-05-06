using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    [SerializeField] private List<Transform> Checkpoints = new List<Transform>();
    private LineRenderer lineRenderer;
    // Start is called before the first frame update
    void Start()
    {
        this.DrawLine();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DrawLine()
    {
        GameObject lineObj = new GameObject();
        this.lineRenderer = lineObj.AddComponent<LineRenderer>();
        this.lineRenderer.startWidth = 0.1f;
        this.lineRenderer.endWidth = 0.1f;
        this.lineRenderer.positionCount = Checkpoints.Count;

        Vector3[] checkPointArray = new Vector3[this.Checkpoints.Count];
        for (int i =0; i < this.Checkpoints.Count; i++)
        {
            Vector3 checkpointpos = this.Checkpoints[i].position;
            checkPointArray[i] = new Vector3(checkpointpos.x, checkpointpos.y, 0f);
        }
        this.lineRenderer.SetPositions(checkPointArray);
    }
}
