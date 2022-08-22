using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RosSharp.RosBridgeClient;


namespace UnityEngine.XR.Interaction.Toolkit
{
    public class GetIntersection : MonoBehaviour
    {
        public GameObject Controller;
        public GameObject TransformHandler;
        public PoseStampedPublisher posePublisher;

        Vector3 m_ReticlePos;
        Vector3 m_ReticleNormal;
        int m_EndPositionInLine;
        // interface to get target point
        ILineRenderable lineRenderable;

        // Start is called before the first frame update
        void Start()
        {

        }

        void Awake()
        {
            posePublisher.FrameId = "Unity";
            lineRenderable = Controller.GetComponent<ILineRenderable>();
            Debug.Log("line: " + lineRenderable);
            posePublisher.enabled = false;
        }

        public void FindPoint()
        {
            lineRenderable.TryGetHitInfo(out m_ReticlePos, out m_ReticleNormal, out m_EndPositionInLine, out var isValidTarget);
            Debug.Log("point hit: " + m_ReticlePos);
            Debug.Log("normal " + m_ReticleNormal);

            m_ReticleNormal = m_ReticleNormal.normalized;
            TransformHandler.transform.position = new Vector3(m_ReticlePos.x + m_ReticleNormal.x * 1 , m_ReticlePos.y + m_ReticleNormal.y * 1 , m_ReticlePos.z + m_ReticleNormal.z * 1);
            TransformHandler.transform.rotation = Quaternion.LookRotation(m_ReticleNormal, Vector3.up);
            posePublisher.FrameId = "true";
            posePublisher.enabled = true;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
