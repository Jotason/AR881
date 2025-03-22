using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TakePicture : MonoBehaviour
{
    public string nameFile;
    public string initialPath;
    public string destinationPath;

    public void TakeScreenshot()
    {
        StartCoroutine(IETakeScreenshot());
    }

    public IEnumerator IETakeScreenshot()
    {

        nameFile = "AR881" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".png";

        //initialPath = Path.Combine("C:/Users/Aprendiz/Documents/Repositorios/AR881/" + nameFile);
        initialPath = Path.Combine(Application.persistentDataPath, nameFile);


        //destinationPath = Path.Combine("C:/Users/Aprendiz/Pictures/" + nameFile);
        destinationPath = Path.Combine("/storage/emulated/0/Download", nameFile);


        ScreenCapture.CaptureScreenshot(nameFile);
        yield return new WaitForSeconds(2f);

        Debug.Log(Application.persistentDataPath);

        MoveFile();
    }


    public void MoveFile()
    {
        
        string _directoryTemp = Path.GetDirectoryName(destinationPath);

        if (!Directory.Exists(_directoryTemp))
        {
            Directory.CreateDirectory(_directoryTemp);
        }

        if (File.Exists(initialPath))
        {
            Debug.Log("a");
            File.Move(initialPath, destinationPath);
        }
    }
}
