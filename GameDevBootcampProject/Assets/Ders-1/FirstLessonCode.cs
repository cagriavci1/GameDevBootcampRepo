using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FirstLessonCode : MonoBehaviour
{
    // 4!     =>   4*3*2*1
    // 112320!    =>   10*9*8*7*6*5*4*3*2*1

    // DEÐÝÞKENLER

    // Cümle, paragraf, isim, özel ad...     => STRÝNG          1 - 1000 
    // sayý, rakam ...                       => INT
    // küsüratlý sayý, ondalýklý sayý        => FLOAT, DOUBLE 
    // tek karakterler, alfabe...            => CHAR
    // iki seçenekli durumlar / dogru-yanlýs => BOOL

    // 10 ==> BÝNARY SYSTEM 

    string benimadým = "Çaðrý Avcý";
    string üniversitem = "Fýrat Üniversitesi";

    char cinsiyetim = 'E';

    int yaþým = 25;
    int boy = 184;
    
    float kilom = 92.5f;

    bool hayattamý = true;

    // Eðer 10-20 arasýnda yaþýn varsa çocuksun
    // Eðer 20-30 arasýnda yaþýn varsa gençsin
    // Eðer 30-40 arasýnda yaþýn varsa yaþlandýn
    // Eðer 40-50 arasýnda yaþýn varsa ölmüþsün sen ya :)


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

        if (yaþým < 20 && yaþým>10)
        {
            Debug.Log("Çocuksun");
        }

        if (yaþým>20 && yaþým<30)
        {
            Debug.Log("Gençsin");
        }

    }
}
// ÖDEV -1 
/*
 * Ýsim soyisim yaþ cinsiyet adres boy kilo bilgilerini ekrana yazdýrýn 
 * Boy kilo endeksinizi veren bir ekran cýktýsý yaptýrýn    ====>   + - * / 
 * 1-100 arasýndaký butun sayýlar ekrana tek tek yazdýrýn   ====>   döngü yapýsý
 * 1-100'e kadar olan sayýlarýn toplamýný ekrana yazdýrýn   ====>   döngü yapýsý
 * 1-100 arasýndaký sayýlardan cýft olanlarý ekrana yazdýrýn ====>  %
 * 1-100 arasýndaki sayýlardan tek olanlarý ekrana yazdýrýn  ====>  %
 * 7! in sonucunu ekrana yazdýrýn
 */