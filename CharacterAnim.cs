using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CharacterAnim : MonoBehaviour
{
    public Animator animator;
    int isWalkingHash, isRunningHash;
 
    void Start()
    {
        //Запрашиваем компонент Animator, который прикреплён к тому же объекту, на котором находится данный скрипт.
        animator = GetComponent<Animator>();
        //Получаем id нужных параметров — так мы сэкономим время на их поиск
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
    }
 
    void Update()
    {
        //Получаем булевы значения результата проверки ввода игрока
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");
 
        //Если зажата клавиша W, то включаем анимацию ходьбы
        if (forwardPressed)
        {
                  animator.SetBool(isWalkingHash, true);
         }
        //Иначе выключаем анимацию ходьбы
        else animator.SetBool(isWalkingHash, false);
        //Если зажаты левый шифт И W, то включаем анимацию бега
        if (forwardPressed && runPressed)
        {
           	     animator.SetBool(isRunningHash, true);
         }
        //Иначе выключаем анимацию бега
        else animator.SetBool(isRunningHash, false);
    }
}
