using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReverseSound : MonoBehaviour
{
	public AudioSource source;
	public Slider slider;

	public void Reverse()
	{
		source.volume = 1 - source.volume;
	}

	public void ChangeValue()
	{
		slider.value = 1 - slider.value;
	}
}
