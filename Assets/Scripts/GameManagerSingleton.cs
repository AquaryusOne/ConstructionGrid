using UnityEngine;
using System.Collections;

public class GameManager {

	private static GameManager myInstance = null;    

	private int nTotalMoney = 100;

	private GameManager() {
	}

	public static GameManager getInstance() {
		if (myInstance == null) {
			myInstance = new GameManager();
			
		}
		return myInstance;
	}

	public int getTotalAmount(){
		return nTotalMoney;
	}

	public void increaseAmount() {
		nTotalMoney++;
	}

	public bool attemptBuy(int nPrice) {
		if (nTotalMoney >= nPrice) {
			nTotalMoney = nTotalMoney - nPrice;
			return true;
		}

		return false;
	}

}
