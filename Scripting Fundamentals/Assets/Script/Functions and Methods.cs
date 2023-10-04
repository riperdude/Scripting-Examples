using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsandMethods : MonoBehaviour
{
    //Funstions are blocks of code that perform specific tasks and are not associated with any specific object or class. They can be called and exected independently.

    //Methods, on the other hand, are functions that are associated with a specific object or class. They can be called and executed on instances of that object or class.

    // Declaring an audio source
    private AudioSource _audioSource;
    private float _speed = 10f;
    private int _playerHealthAmount = 100;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //Function to detect Triggers
    private void PlaySoundEffect(AudioClip soundEffect)
    {
        _audioSource.PlayOneShot(soundEffect);
    }
    private void OnTriggerEnter(Collider other)
    {

    }

    // Creating some simple methods

    // Method to move the enemy
    private void MoveEnemy() 
    {
    transform.Translate( Vector3.forward * _speed * Time.deltaTime);
    }

    //Method to return a value
    public int PlayerHealth(int amount)
    {
        _playerHealthAmount -= amount;

        return _playerHealthAmount;
    }
}
