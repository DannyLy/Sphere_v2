using UnityEngine;
using System.Collections;

public class BossGun : MonoBehaviour {

	public Transform muzzle;
	public Projectile projectile;
	public float msBetweenShots = 100;
	public float muzzleVelocity = 35;
	
	float nextShotTime;
	
	void FixedUpdate () {
		Shoot ();
	}

	public void Shoot() {
		
		if(Time.time > nextShotTime){
			nextShotTime = Time.time + msBetweenShots / 1000;


				Projectile newProjectileN = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, muzzle.transform.rotation.y, 0 )) as Projectile;
				Projectile newProjectileNE = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, muzzle.transform.rotation.y+45, 0 )) as Projectile;
				Projectile newProjectileE = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, muzzle.transform.rotation.y+90, 0 )) as Projectile;
				Projectile newProjectileSE = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, muzzle.transform.rotation.y+135, 0 )) as Projectile;
				Projectile newProjectileS = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, muzzle.transform.rotation.y+180, 0 )) as Projectile;
				Projectile newProjectileSW = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, muzzle.transform.rotation.y+225, 0 )) as Projectile;
				Projectile newProjectileW = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, muzzle.transform.rotation.y+270, 0 )) as Projectile;
				Projectile newProjectileNW = Instantiate (projectile, muzzle.position, Quaternion.Euler(0, muzzle.transform.rotation.y+315, 0 )) as Projectile;
				
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
