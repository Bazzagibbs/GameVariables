using UnityEngine;

namespace BazzaGibbs.GameVariables.Demo{
    public class HealthManager : MonoBehaviour {
        [SerializeField] private FloatRef m_PlayerHealth;
        [SerializeField] private FloatRef m_MaxHealth;
        [SerializeField] private FloatRef m_ImpactDamage;

        private void Start() {
            m_PlayerHealth.val = m_MaxHealth.val;
        }
        
        private void OnTriggerEnter(Collider other) {
            m_PlayerHealth.val = Mathf.Max(0, m_PlayerHealth.val - m_ImpactDamage.val);
        }

        // Could be hooked up to GameEvents
        public void Heal(float hp) {
            m_PlayerHealth.val = Mathf.Min(m_PlayerHealth.val + hp, m_MaxHealth.val);
        }
    }
}
