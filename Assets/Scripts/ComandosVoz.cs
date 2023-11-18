using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class NewBehaviourScript1 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;

    Dictionary<string, System.Action> wordToAction;

    public GameObject arma;

    
    void Start()
    {


        arma.SetActive(false);

        wordToAction = new Dictionary<string, Action>();
        wordToAction.Add("activar arma", ActivarArma);
        wordToAction.Add("desactivar arma", DesactivarArma);

        keywordRecognizer = new KeywordRecognizer(wordToAction.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += WordRecognized;
        keywordRecognizer.Start();
    }

    private void WordRecognized(PhraseRecognizedEventArgs word)
    {
        Debug.Log(word.text);
        wordToAction[word.text].Invoke();
    }

    private void ActivarArma()
    {
        arma.SetActive(true);
    }

    private void DesactivarArma()
    {
        arma.SetActive(false);
    }
}
