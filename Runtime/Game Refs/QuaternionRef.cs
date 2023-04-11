// Generated script for BazzaGibbs.GameVariables package

using System;
using UnityEngine;

namespace BazzaGibbs.GameVariables {
    [Serializable]
    public class QuaternionRef {
        public bool useConstantVal;
        public Quaternion constantVal;
        public QuaternionVar gameVariable;
        
        public QuaternionRef() { }
        
        public QuaternionRef(QuaternionVar variable) {
            useConstantVal = false;
            gameVariable = variable;
        }
        
        public QuaternionRef(Quaternion constant) {
            useConstantVal = true;
            constantVal = constant;
        }
        
        public Quaternion val {
            get { return useConstantVal ? constantVal : gameVariable.val; }
            set {
                if (useConstantVal) {
                    constantVal = value;
                }
                else {
                    gameVariable.val = value;
                }
            }
        }
    }
}
