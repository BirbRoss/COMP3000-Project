using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fired : MonoBehaviour
{
    [SerializeField] float lifetime = 3.0f;
    [SerializeField] float launchForce = 10.0f;
    Rigidbody rb;
    public AudioClip dissolve;

    gameManager gm;

    //prevents double collission trigger from entering new colliders
    bool triggered = false;

    // Start is called before the first frame update
    void Start()
    {
        float rng = Random.Range(0.0f, 3.0f);

        Invoke("deleteThis", lifetime);
        rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * (launchForce + rng), ForceMode.Impulse);

        gm = GameObject.Find("GameManager").GetComponent<gameManager>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "noodle" && !triggered)
        {
            //Turns of the collider entirely, plays a particle then fades out after a moment
            triggered = true;

            Vector3 knockbckDirection = col.transform.position - transform.position;
            rb.AddForce(knockbckDirection.normalized * 10, ForceMode.VelocityChange);

            gm.SendMessage("addPoints", null);
            gameObject.GetComponent<ParticleSystem>().Play();
            gameObject.GetComponent<AudioSource>().PlayOneShot(dissolve);
            Invoke("deleteThis", 0.5f);
        }
        else if (col.gameObject.tag !=  "ball" || !triggered)
        {
            triggered = true;
            deleteThis();
        }
    }

    void deleteThis()
    {
        //Prevents it from being triggered by a colider then plays a fade animation before destroying
        triggered = true;
        Animator anim = gameObject.GetComponent<Animator>();
        anim.Play("projFadeOut");
        Destroy(gameObject, anim.GetCurrentAnimatorStateInfo(0).length);
    }
}
