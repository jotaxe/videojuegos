using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerData {
	private static int gameOneScore, gameTwoScore, gameThreeScore;
	
	private static string character = "prueba";
	
	public static string Character {
		get {
			return character;
		}
		set {
			character = value;
		}
	}

	public static int GameOneScore {
		get {
			return gameOneScore;
		}
		set {
			gameOneScore = value;
		}
	}

	public static int GameTwoScore {
		get {
			return gameTwoScore;
		}
		set {
			gameTwoScore = value;
		}
	}

	public static int GameThreeScore {
		get {
			return gameThreeScore;
		}
		set {
			gameThreeScore = value;
		}
	}
}