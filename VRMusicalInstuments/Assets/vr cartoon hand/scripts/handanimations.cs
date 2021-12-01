using UnityEngine;
using System.Collections;

public class handanimations : MonoBehaviour
{

	public GameObject ViveController;
	public GameObject OculusController;
	public GameObject StickMaracas; //마라카스 스틱
	public GameObject StickDrum; //드럼 스틱
    public GameObject Drum;
    public GameObject Particle;

    private Vector3 oriDirection;
    private Vector3 chaDirection; //회전방향

	private bool flag; //악기를 들고있는지 여부를 저장하는 것
    private string musicalName; //현재 연주중인 악기에 대한 정보를 저장할 것

	public AudioClip audioMaracas; //마라카스 음성파일을 저장해 둘 곳
	public AudioClip audioDrum; //드럼 음성파일을 저장해 둘 곳
	AudioSource audioSource;

    Animator anim;
    int Idle = Animator.StringToHash("Idle");
    int Point = Animator.StringToHash("Point");
    int GrabLarge = Animator.StringToHash("GrabLarge");
    int GrabSmall = Animator.StringToHash("GrabSmall");
    int GrabStickUp = Animator.StringToHash("GrabStickUp");
    int GrabStickFront = Animator.StringToHash("GrabStickFront");
    int ThumbUp = Animator.StringToHash("ThumbUp");
    int Fist = Animator.StringToHash("Fist");
    int Gun = Animator.StringToHash("Gun");
    int GunShoot = Animator.StringToHash("GunShoot");
    int PushButton = Animator.StringToHash("PushButton");
    int Spread = Animator.StringToHash("Spread");
    int MiddleFinger = Animator.StringToHash("MiddleFinger");
    int Peace = Animator.StringToHash("Peace");
    int OK = Animator.StringToHash("OK");
	int Phone = Animator.StringToHash("Phone");
	int Rock = Animator.StringToHash("Rock");
	int Natural = Animator.StringToHash("Natural");
	int Number3 = Animator.StringToHash("Number3");
	int Number4 = Animator.StringToHash("Number4");
	int Number3V2 = Animator.StringToHash("Number3V2");
	int HoldViveController = Animator.StringToHash("HoldViveController");
	int PressTriggerViveController = Animator.StringToHash("PressTriggerViveController");
	int HoldOculusController = Animator.StringToHash("HoldOculusController");
	int PressTriggerOculusController = Animator.StringToHash("PressTriggerOculusController");

    void Start ()
    {
        anim = GetComponent<Animator>();
		OculusController.SetActive (false);
		ViveController.SetActive (false);
		StickMaracas.SetActive (false);
		StickDrum.SetActive (false);
		Particle.SetActive (false);

        oriDirection = new Vector3(-78,-141,29);
        chaDirection = new Vector3(14,-18,-78);

        musicalName = "";
		this.audioSource = GetComponent<AudioSource>();

		flag = false; // 마라카스를 쥐고 놓는 플래그형 변수로 사용될 것

    }

    void Update()
    {
   //     if (Input.GetKeyDown(KeyCode.Q))
   //     {
   //         anim.SetTrigger(Idle);
			//OculusController.SetActive (false);
			//ViveController.SetActive (false);
			//StickUp.SetActive (false);
			//StickFront.SetActive (false);
   //     }

   //     else if (Input.GetKeyDown(KeyCode.W))
   //     {
   //         anim.SetTrigger(Point);
			//OculusController.SetActive (false);
			//ViveController.SetActive (false);
			//StickUp.SetActive (false);
			//StickFront.SetActive (false);
   //     }

   //     else if (Input.GetKeyDown(KeyCode.E))
   //     {
   //         anim.SetTrigger(GrabLarge);
			//OculusController.SetActive (false);
			//ViveController.SetActive (false);
			//StickUp.SetActive (false);
			//StickFront.SetActive (false);
   //     }

   //     else if (Input.GetKeyDown(KeyCode.R))
   //     {
   //         anim.SetTrigger(GrabSmall);
			//OculusController.SetActive (false);
			//ViveController.SetActive (false);
			//StickUp.SetActive (false);
			//StickFront.SetActive (false);
   //     }

   //     else if (Input.GetKeyDown(KeyCode.T))
   //     {
   //         anim.SetTrigger(GrabStickUp);
			//OculusController.SetActive (false);
			//ViveController.SetActive (false);
			//StickUp.SetActive (true);
			//StickFront.SetActive (false);
   //     }

        if (Input.GetKeyDown(KeyCode.Y))
        {


			if (flag == false)
			{
                musicalName = "Maracas";
				anim.SetTrigger(GrabStickFront);
				OculusController.SetActive(false);
				ViveController.SetActive(false);
				StickMaracas.SetActive(true);
				StickDrum.SetActive(false);
				flag = true;
                PlaySound("MARACAS");

            }
			else
			{
                musicalName = "";
				anim.SetTrigger(Idle);
				OculusController.SetActive(false);
				ViveController.SetActive(false);
				StickMaracas.SetActive(false);
				StickDrum.SetActive(false);

				flag = false;

			}

        }

        else if (Input.GetKeyDown(KeyCode.U))
        {
            if (flag == false)
            {

                Drum.SetActive(true);

                musicalName = "Drum";
                anim.SetTrigger(GrabStickFront);
                OculusController.SetActive(false);
                ViveController.SetActive(false);
                StickMaracas.SetActive(false);
                StickDrum.SetActive(true);
                flag = true;
                PlaySound("DRUM");

            }
            else
            {

                Drum.SetActive(false);

                musicalName = "";
                anim.SetTrigger(Idle);
                OculusController.SetActive(false);
                ViveController.SetActive(false);
                StickMaracas.SetActive(false);
                StickDrum.SetActive(false);
                flag = false;

            }
        }

        //      else if (Input.GetKeyDown(KeyCode.I))
        //      {
        //          anim.SetTrigger(Fist);
        //	OculusController.SetActive (false);
        //	ViveController.SetActive (false);
        //	StickUp.SetActive (false);
        //	StickFront.SetActive (false);
        //      }

        //      else if (Input.GetKeyDown(KeyCode.O))
        //      {
        //          anim.SetTrigger(Gun);
        //	OculusController.SetActive (false);
        //	ViveController.SetActive (false);
        //	StickUp.SetActive (false);
        //	StickFront.SetActive (false);
        //      }
        //      else if (Input.GetKeyDown(KeyCode.P))
        //      {
        //          anim.SetTrigger(GunShoot);
        //	OculusController.SetActive (false);
        //	ViveController.SetActive (false);
        //	StickUp.SetActive (false);
        //	StickFront.SetActive (false);
        //      }
        //      else if (Input.GetKeyDown(KeyCode.A))
        //      {
        //          anim.SetTrigger(PushButton);
        //	OculusController.SetActive (false);
        //	ViveController.SetActive (false);
        //	StickUp.SetActive (false);
        //	StickFront.SetActive (false);
        //      }
        //      else if (Input.GetKeyDown(KeyCode.S))
        //      {
        //          anim.SetTrigger(Spread);
        //	OculusController.SetActive (false);
        //	ViveController.SetActive (false);
        //	StickUp.SetActive (false);
        //	StickFront.SetActive (false);
        //      }
        //      else if (Input.GetKeyDown(KeyCode.D))
        //      {
        //          anim.SetTrigger(MiddleFinger);
        //	OculusController.SetActive (false);
        //	ViveController.SetActive (false);
        //	StickUp.SetActive (false);
        //	StickFront.SetActive (false);
        //      }
        //      else if (Input.GetKeyDown(KeyCode.F))
        //      {
        //          anim.SetTrigger(Peace);
        //	OculusController.SetActive (false);
        //	ViveController.SetActive (false);
        //      }
        //      else if (Input.GetKeyDown(KeyCode.G))
        //      {
        //          anim.SetTrigger(OK);
        //	OculusController.SetActive (false);
        //	ViveController.SetActive (false);
        //	StickUp.SetActive (false);
        //	StickFront.SetActive (false);
        //      }
        //else if (Input.GetKeyDown(KeyCode.H))
        //      {
        //          anim.SetTrigger(Phone);
        //	OculusController.SetActive (false);
        //	ViveController.SetActive (false);
        //	StickUp.SetActive (false);
        //	StickFront.SetActive (false);
        //      }
        //else if (Input.GetKeyDown(KeyCode.J))
        //      {
        //          anim.SetTrigger(Rock);
        //	OculusController.SetActive (false);
        //	ViveController.SetActive (false);
        //	StickUp.SetActive (false);
        //	StickFront.SetActive (false);
        //      }
        //else if (Input.GetKeyDown(KeyCode.K))
        //      {
        //          anim.SetTrigger(Natural);
        //	OculusController.SetActive (false);
        //	ViveController.SetActive (false);
        //	StickUp.SetActive (false);
        //	StickFront.SetActive (false);
        //      }
        //else if (Input.GetKeyDown(KeyCode.L))
        //      {
        //          anim.SetTrigger(Number3);
        //	OculusController.SetActive (false);
        //	ViveController.SetActive (false);
        //	StickUp.SetActive (false);
        //	StickFront.SetActive (false);
        //      }
        //else if (Input.GetKeyDown(KeyCode.X))
        //      {
        //          anim.SetTrigger(Number4);
        //	OculusController.SetActive (false);
        //	ViveController.SetActive (false);
        //	StickUp.SetActive (false);
        //	StickFront.SetActive (false);
        //      }
        //else if (Input.GetKeyDown(KeyCode.Z))
        //{
        //	anim.SetTrigger(Number3V2);
        //	OculusController.SetActive (false);
        //	ViveController.SetActive (false);
        //	StickUp.SetActive (false);
        //	StickFront.SetActive (false);
        //}
        //else if (Input.GetKeyDown(KeyCode.C))
        //{
        //	anim.SetTrigger(HoldViveController);
        //	ViveController.SetActive (true);
        //	OculusController.SetActive (false);
        //	StickUp.SetActive (false);
        //	StickFront.SetActive (false);
        //}
        //else if (Input.GetKeyDown(KeyCode.V))
        //{
        //	anim.SetTrigger(PressTriggerViveController);
        //	ViveController.SetActive (true);
        //	OculusController.SetActive (false);
        //	StickUp.SetActive (false);
        //	StickFront.SetActive (false);
        //}
        //else if (Input.GetKeyDown(KeyCode.B))
        //{
        //	anim.SetTrigger(HoldOculusController);
        //	OculusController.SetActive (true);
        //	ViveController.SetActive (false);
        //	StickUp.SetActive (false);
        //	StickFront.SetActive (false);
        //}
        //else if (Input.GetKeyDown(KeyCode.N))
        //{
        //	anim.SetTrigger(PressTriggerOculusController);
        //	OculusController.SetActive (true);
        //	ViveController.SetActive (false);
        //	StickUp.SetActive (false);
        //	StickFront.SetActive (false);
        //}
    } //손 움직임과 관련된 스크립트 현재는 쥐고있는 자세와 놓는 자세만 넣어주었음


    void OnMouseDown() {


        if (flag == true && musicalName == "Maracas") { 
        
            Particle.SetActive(true);
            audioSource.Play();        
        
        }

        else if(musicalName == "Drum"){

            transform.rotation = Quaternion.Euler(chaDirection);

        }

    
    }

	void OnMouseDrag() //드래그 이벤트
	{

        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
		


    }

    void OnMouseUp() {


        if (flag == true)
        {

            Particle.SetActive(false);
            audioSource.Stop();
            transform.rotation = Quaternion.Euler(oriDirection);

        }


    }

	void PlaySound(string action) {

		switch (action) {

			case "MARACAS":
				audioSource.clip = audioMaracas;
                audioSource.loop = true;
				break;
			case "DRUM":
				audioSource.clip = audioDrum;
                audioSource.loop = false;
                break;
		}

	}

    void OnTriggerEnter(Collider other) {

        if (other.gameObject.CompareTag("Drum")) {

            Debug.Log("충돌 발생");
            audioSource.Play();

        }
    }

}