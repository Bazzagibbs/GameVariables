using UnityEngine;
using UnityEngine.UI;


namespace BazzaGibbs.GameVariables.Demo {
    public class HealthListener : MonoBehaviour {
        [SerializeField] private FloatRef m_MaxHealth;
        [SerializeField] private FloatRef m_PlayerHealth;
        private Slider m_HealthBar;

        private void Start() {
            m_HealthBar = GetComponent<Slider>();
        }
        
        private void Update() {
            m_HealthBar.value = m_PlayerHealth.val / m_MaxHealth.val;
            
        }
    }
}
