using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragable : MonoBehaviour
{
    Vector2 difference = Vector2.zero;
    [SerializeField] bool isOnDrag;
    [SerializeField] GameObject onCharacterSprites;
    [SerializeField] GameObject checkBoxFill;
    Vector3 startPosition;
    bool onCharacter;


    private void Start()
    {
        startPosition = transform.position;
    }
    private void OnMouseDown()
    {
        difference = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
        isOnDrag = true;
    }

    private void OnMouseDrag()
    {
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;
    }

    private void OnMouseUp()
    {
        isOnDrag = false;
        if (!onCharacter)
        {
            transform.position = startPosition;
        }
    }


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player" )
        {
            onCharacter = true;
            if (!isOnDrag)
            {
                EnableClothes();
            }

        }
    }

    void EnableClothes()
    {
        gameObject.SetActive(false);
        onCharacterSprites.SetActive(true);
        checkBoxFill.SetActive(true);
        SOPController.instance.addCompletedSOP();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            onCharacter = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            onCharacter = false;
        }
    }

}
