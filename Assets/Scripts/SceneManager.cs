using System;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
	public static SceneManager Instance;

	public BombGenerator BombGenerator;
	public int NumStrikesToLose;

	public Bomb Bomb;

	void Awake()
	{
		Instance = this;
	}

	void Start()
	{
		//Eventually options and game flow will go here
		Bomb = BombGenerator.CreateBomb(NumStrikesToLose);
    }
}

