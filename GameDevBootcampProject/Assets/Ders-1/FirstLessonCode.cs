using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FirstLessonCode : MonoBehaviour
{
    // 4!     =>   4*3*2*1
    // 112320!    =>   10*9*8*7*6*5*4*3*2*1

    // DE���KENLER

    // C�mle, paragraf, isim, �zel ad...     => STR�NG          1 - 1000 
    // say�, rakam ...                       => INT
    // k�s�ratl� say�, ondal�kl� say�        => FLOAT, DOUBLE 
    // tek karakterler, alfabe...            => CHAR
    // iki se�enekli durumlar / dogru-yanl�s => BOOL

    // 10 ==> B�NARY SYSTEM 

    string benimad�m = "�a�r� Avc�";
    string �niversitem = "F�rat �niversitesi";

    char cinsiyetim = 'E';

    int ya��m = 25;
    int boy = 184;
    
    float kilom = 92.5f;

    bool hayattam� = true;

    // E�er 10-20 aras�nda ya��n varsa �ocuksun
    // E�er 20-30 aras�nda ya��n varsa gen�sin
    // E�er 30-40 aras�nda ya��n varsa ya�land�n
    // E�er 40-50 aras�nda ya��n varsa �lm��s�n sen ya :)


    // MANTIKSAL OPERATORLER
    // <
    // >
    // =
    // <=
    // >=
    // !
    // !=
  

    // KARAR OPERATORLERI
    // VE ==>>  &&
    // VEYA ==>> ||

    private void Start()
    {

        if (ya��m < 20 && ya��m>10)
        {
            Debug.Log("�ocuksun");
        }

        if (ya��m>20 && ya��m<30)
        {
            Debug.Log("Gen�sin");
        }

    }
}
// �DEV -1 
/*
 * �sim soyisim ya� cinsiyet adres boy kilo bilgilerini ekrana yazd�r�n 
 * Boy kilo endeksinizi veren bir ekran c�kt�s� yapt�r�n    ====>   + - * / 
 * 1-100 aras�ndak� butun say�lar ekrana tek tek yazd�r�n   ====>   d�ng� yap�s�
 * 1-100'e kadar olan say�lar�n toplam�n� ekrana yazd�r�n   ====>   d�ng� yap�s�
 * 1-100 aras�ndak� say�lardan c�ft olanlar� ekrana yazd�r�n ====>  %
 * 1-100 aras�ndaki say�lardan tek olanlar� ekrana yazd�r�n  ====>  %
 * 7! in sonucunu ekrana yazd�r�n
 */