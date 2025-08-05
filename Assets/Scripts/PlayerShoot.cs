using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject prefab;
    public GameObject prefab2;
    public Transform bulletTrash;
    public Transform bulletSpawn;

    private const float Timer = 0.5f;
    private float _currentTime = 0.5f;
    private bool _canShoot = true;

    private void Update()
    {
        timeMethod();

        shoot();

    }

    private void shoot()
    { 
    if (Input.GetKeyDown(KeyCode.Mouse0) && _canShoot)
        {
            GameObject bullet = Instantiate(prefab, bulletSpawn.position, Quaternion.identity);

             bullet.transform.SetParent(bulletTrash);

            _canShoot = false;
        }

    if (Input.GetKeyDown(KeyCode.Mouse1)  && _canShoot)
        {
            GameObject bullet = Instantiate(prefab2, bulletSpawn.position, Quaternion.identity);

            bullet.transform.SetParent(bulletTrash);

            _canShoot = false;

        }
     }

    private void timeMethod()
    {
        if (!_canShoot)
        {
            _currentTime -= Time.deltaTime;

            if (_currentTime < 0)
            {
                _canShoot = true;
                _currentTime = Timer;
            }
        }
    }
    
}
