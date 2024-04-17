using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AIText : MonoBehaviour
{

    public TextMeshProUGUI bodyText;
    public AudioSource voiceAI;

    public GameObject AICanvas;

    // Start is called before the first frame update
    void Start()
    {


        StartCoroutine(PlaySounds());


        //  instructions[0] = "Walk around to ensure the scene is safe for both you and the victim.";
        //  instructions[1] = "A virtual medical expert will be connecting shortly. In the mean time, and identify the wound.";

        /* instructions[2] = "Identify the source of the bleeding.";
         instructions[3] = "Retrieve the bandage on the ground.";
         instructions[3] = "Apply plessure to the wound with a bandage.";
         instructions[4] = "If the bleed does not stop with pressure, locate a tourniquet.";
         instructions[4] = "Apply the tourniquet.";
         instructions[5] = "Monitor and keep the victim calm.";
         instructions[6] = "Good job stopping the bleed.";*/


        // bodyText.text = instructions[currentInstruction];

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PlaySounds()
    {

        yield return new WaitForSeconds(10);

        voiceAI.Play();
         yield return new WaitForSeconds(4);



        //delete AI canvas

        AICanvas.SetActive(false);

    }

   

    public void nextStep()
    {
     /*   if(currentInstruction < instructions.Length)
        {

            currentInstruction++;
        } else
        {
            currentInstruction = 0;
        }

        bodyText.text = instructions[currentInstruction];*/
    }
}
