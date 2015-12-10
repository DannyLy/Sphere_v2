using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {
	
	public Transform muzzle;
	public Projectile projectile;
	public float msBetweenShots = 100;
	public float muzzleVelocity = 35;
	public int gunType = 0;
	
	float nextShotTime;
	
	public void Shoot() {
		
		if(Time.time > nextShotTime){
			nextShotTime = Time.time + msBetweenShots / 1000;

			/////*** NORMAL ***\\\\\
			if(gunType == 0){
				Projectile newProjectile = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0)) as Projectile;
				newProjectile.SetSpeed (muzzleVelocity);
			}

			/////*** SHOTGUN ***\\\\\
			if(gunType == 1){
				Projectile newProjectileL = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, Camera.main.transform.eulerAngles.y + 350, 0)) as Projectile;
				Projectile newProjectileF = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0)) as Projectile;
				Projectile newProjectileR = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, Camera.main.transform.eulerAngles.y + 10, 0)) as Projectile;
				newProjectileL.SetSpeed (muzzleVelocity);
				newProjectileF.SetSpeed (muzzleVelocity);
				newProjectileR.SetSpeed (muzzleVelocity);
			}

			/////*** 360 SHOT ***\\\\\
			if(gunType == 2){
			
				Projectile newProjectileN = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0)) as Projectile;
				Projectile newProjectileNE = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, Camera.main.transform.eulerAngles.y + 45, 0)) as Projectile;

				Projectile newProjectileE = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, Camera.main.transform.eulerAngles.y + 90, 0)) as Projectile;
				Projectile newProjectileSE = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, Camera.main.transform.eulerAngles.y + 135, 0)) as Projectile;

				Projectile newProjectileS = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, Camera.main.transform.eulerAngles.y + 180, 0)) as Projectile;
				Projectile newProjectileSW = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, Camera.main.transform.eulerAngles.y + 225, 0)) as Projectile;

				Projectile newProjectileW = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, Camera.main.transform.eulerAngles.y + 270, 0)) as Projectile;
				Projectile newProjectileNW = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, Camera.main.transform.eulerAngles.y + 315, 0)) as Projectile;

				newProjectileN.SetSpeed (muzzleVelocity);
				newProjectileNE.SetSpeed (muzzleVelocity);
				newProjectileE.SetSpeed (muzzleVelocity);
				newProjectileSE.SetSpeed (muzzleVelocity);
				newProjectileS.SetSpeed (muzzleVelocity);
				newProjectileSW.SetSpeed (muzzleVelocity);
				newProjectileW.SetSpeed (muzzleVelocity);
				newProjectileNW.SetSpeed (muzzleVelocity);

			}
		}

	}
	
}
