using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public List<Transform> targets;

    public Vector3 offset = new Vector3(-6.6f, 6.8f, -4.8f);

    private Vector3 velocity;
    public float smoothTime = .5f;

    public float maxZoom = 275f;
    public float minZoom = 1.65f;

    public float zoomLimit = 50f;

    float targetDist;

    private Camera cam;

    private void Start()
    {
        cam = GetComponent<Camera>();
    }
    private void LateUpdate()
    {
        if (targets.Count == 0)
            return;

        Move();
        Zomm();
        Dist();
    }

    private void Dist()
    {
        targetDist = Vector3.Distance(targets[0].position, targets[1].position);

    }

    void Zomm()
    {
        if (targets.Count == 0)
            return;

        float newZoom = Mathf.Lerp(minZoom, maxZoom, targetDist / zoomLimit);

        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, newZoom, Time.deltaTime);
    }

    void Move()
    {
        Vector3 centerPoint = GetCenterPoint();

        Vector3 newPosition = centerPoint + offset;

        transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref velocity, smoothTime);
    }

    Vector3 GetCenterPoint()
    {
        if (targets.Count == 1)
        {
            return targets[0].position;
        }

        var bounds = new Bounds(targets[0].position, Vector3.zero);

        for (int targetsAmount = 0; targetsAmount < targets.Count; targetsAmount++)
        {
            bounds.Encapsulate(targets[targetsAmount].position);
        }

        return bounds.center;
    }
}
