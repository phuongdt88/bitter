using UnityEngine;
using UnityEngine.UI;

public class TankShooting : MonoBehaviour
{
    public GameObject shell;
    public Transform shotSpawn;
    public float fireRate;

    private float nextFire;
    private float numShots = 5f;            // Number of shots fired (should be odd); 
    private float spreadAngle = 10f;       // Angle between shots
    // public int m_PlayerNumber = 1;       
    // public Rigidbody m_Shell;            
    // public Transform m_FireTransform;    
    // public Slider m_AimSlider;           
    // public AudioSource m_ShootingAudio;  
    // public AudioClip m_ChargingClip;     
    // public AudioClip m_FireClip;         
    // public float m_MinLaunchForce = 15f; 
    // public float m_MaxLaunchForce = 30f; 
    // public float m_MaxChargeTime = 0.75f;

    /*
    private string m_FireButton;         
    private float m_CurrentLaunchForce;  
    private float m_ChargeSpeed;         
    private bool m_Fired;                


    private void OnEnable()
    {
        m_CurrentLaunchForce = m_MinLaunchForce;
        m_AimSlider.value = m_MinLaunchForce;
    }


    private void Start()
    {
        m_FireButton = "Fire" + m_PlayerNumber;

        m_ChargeSpeed = (m_MaxLaunchForce - m_MinLaunchForce) / m_MaxChargeTime;
    }
    */

    private void Update()
    {
        if (Input.GetKeyDown("space") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Fire2();
        }
    }

    private void Fire()
    {
        // Instantiate and launch the shell.
        Instantiate(shell, shotSpawn.position, shotSpawn.rotation);
    }
    //dit me tinh tong goc
    private void Fire2() {
        Quaternion qAngle = Quaternion.AngleAxis (((-numShots +1) / 2.0f) * spreadAngle, shotSpawn.up) * shotSpawn.rotation;
      
        // Debug.Log(qAngle);
        Quaternion qDelta = Quaternion.AngleAxis (spreadAngle, shotSpawn.up);
        
        for (int i = 0; i < numShots; i++) {

            Debug.Log(qAngle);
            GameObject go = (GameObject) Instantiate (shell, shotSpawn.position, qAngle);
            qAngle = qDelta * qAngle;
        }
    }
}