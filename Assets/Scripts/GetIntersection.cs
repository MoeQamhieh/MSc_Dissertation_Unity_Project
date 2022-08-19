using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UnityEngine.XR.Interaction.Toolkit
{
    public class GetIntersection : MonoBehaviour
    {
        public GameObject Controller;

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
            lineRenderable = Controller.GetComponent<ILineRenderable>();
            Debug.Log("line: " + lineRenderable);
        }

        public void FindPoint()
        {
            lineRenderable.TryGetHitInfo(out m_ReticlePos, out m_ReticleNormal, out m_EndPositionInLine, out var isValidTarget);
            Debug.Log("point hit: " + m_ReticlePos);
            Debug.Log("normal " + m_ReticleNormal);
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}
