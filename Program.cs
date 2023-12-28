using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__ders_tekrsrı
{
    class personel
    {
        private string TCNO;

        public string Tckimlik
        {
            get
            {
               if(TCNO == null)
                {
                    return TCNO + "Hatalı giriş yaptınız: ";
                }
                else
                {
                    return TCNO.Substring(0, 4) + "*******";
                }

            }
            set
            {
                bool kontrol = false;
                if(value.Length == 11)
                {
                    for(int i = 0; i< value.Length; i++)
                    {
                        bool SayiMi = char.IsNumber(value[i]);

                        if(SayiMi)
                        {
                            
                        }
                        else
                        {
                            kontrol = true;
                            break;
                        }
                    }
                    
                    if(kontrol)
                    {
                        Console.WriteLine("Lütfen karekter değeri giriniz: ");
                    }
                    else
                    {
                        TCNO = value;
                    }
                   
                }
                else
                {
                    Console.WriteLine( "girdiğiniz karekter 11 haneli olmak zorundadır !! ");
                }

            }
        }

    }






    internal class Program
    {
      
        static void Main(string[] args)
        {
            personel TC = new personel();
            TC.Tckimlik = "15433420844";
            Console.WriteLine(" 11 haneli tc numarası : "+TC.Tckimlik);
         
          
            Console.ReadLine();


        }
    }

}


