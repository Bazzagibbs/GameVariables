using System;
using UnityEngine;

namespace BazzaGibbs.GameVariables.Demo {
    public class EnemyMover : MonoBehaviour {
        [SerializeField] private FloatRef m_OscillateTime;
        [SerializeField] private FloatRef m_MinX;
        [SerializeField] private FloatRef m_MaxX;
        private float m_Timer;

        private void Update() {
            // Sine wave oscillation
            float t = (Mathf.Cos((m_Timer / m_OscillateTime.val) * (float)(2 * Math.PI)) + 1) / 2.0f;
            float xPos = Mathf.Lerp(m_MinX.val, m_MaxX.val, t);
            transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
            
            m_Timer += Time.deltaTime;
            m_Timer %= m_OscillateTime.val;
        }
    }
}
