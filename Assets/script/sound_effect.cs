using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class sound_effect : MonoBehaviour {
	AudioSource audioData;
	//Play the music
	bool play;
	//Detect when you use the toggle, ensures music isn’t played multiple times
	bool toggleChange;
	// Start is called before the first frame update
	private void Start() {
		audioData = GetComponent<AudioSource>();
		play = true;
	}
	
	void Update() {
		//Check to see if you just set the toggle to positive
		if(play == true && toggleChange == true) {
			//Play the audio you attach to the AudioSource component
			audioData.Play();
			//Ensure audio doesn’t play more than once
			toggleChange = false;
		}
		//Check if you just set the toggle to false
		if(play == false && toggleChange == true) {
			//Stop the audio
			audioData.Stop();
			//Ensure audio doesn’t play more than once
			toggleChange = false;
		}
	}
}
