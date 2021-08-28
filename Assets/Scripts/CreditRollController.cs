using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditRollController : MonoBehaviour {

    public Animator animator;

    void Update() {
        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !animator.IsInTransition(0)) {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }
}
