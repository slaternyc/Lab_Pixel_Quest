using UnityEngine;

public class HW2PlayerShoot : MonoBehaviour
{
    public GameObject preFab;
    public GameObject preFab2;
    public Transform bulletTrash;
    public Transform bulletSpawn;

    private const float Timer = 0.5f;
    private float _currentTime = 0.5f;
    private bool _canShoot = true;
    private void Update()
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
            
            
        if(Input.GetKeyUp(KeyCode.Mouse0) && _canShoot)
        { 
            GameObject bullet = Instantiate(preFab, bulletSpawn.position, Quaternion.identity);

            bullet.transform.SetParent(bulletTrash);

            _canShoot = false;
    
        }

        if (Input.GetKeyUp(KeyCode.Mouse1) && _canShoot)
        {
            GameObject bullet = Instantiate(preFab2, bulletSpawn.position, Quaternion.identity);

            bullet.transform.SetParent(bulletTrash);

            _canShoot = false;

        }
    }
}
