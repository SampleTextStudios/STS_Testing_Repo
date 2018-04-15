using UnityEditor;
using UnityEngine;

public class Notepad : MonoBehaviour
{

	[TextArea]
	[Tooltip("Doesn't do anything. Just comments shown in inspector")]
	public string Notes;
}
