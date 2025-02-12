using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour {
	[SerializeField] private GM_Game1 m_GM;

	private Vector3 m_SelfScale;

	private void Start() {
		m_SelfScale = gameObject.transform.localScale;
		gameObject.transform.localScale = new Vector3(SetScaleX(), m_SelfScale.y, m_SelfScale.z);
	}

	private void FixedUpdate() {
		gameObject.transform.localScale = new Vector3(SetScaleX(), m_SelfScale.y, m_SelfScale.z);
	}

	private float SetScaleX() {
		return (float) m_GM.m_Score / 100.0f;
	}
}