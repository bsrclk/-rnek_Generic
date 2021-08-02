using System;
using System.Collections.Generic;

namespace Örnek_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ÖrnekList = new List<string>();//bu normal liste
          
            
            ÖrnekList.Add("ANTALYA");
            ÖrnekList.Add("ANTALYA");
            ÖrnekList.Add("ANTALYA");
            ÖrnekList.Add("ANTALYA");
         
            Console.WriteLine(ÖrnekList.Count);

            MyList<string> BenimList = new MyList<string>();//bu generic liste
            BenimList.Add("kars");
            BenimList.Add("kars");
            BenimList.Add("kars");
            BenimList.Add("kars"); 
            BenimList.Add("kars");
            BenimList.Add("kars");
            BenimList.Add("kars");
            Console.WriteLine(BenimList.Count);
           







        }


        class MyList<T>//bu şekilde kçşeli parantez eklememizin sebebi yukarıda MyList<> şeklinde yazmamız
        {
            T[] _array;//Listeler Array bazlıdır ve T tipinde bir Array oluşturduj
            T[] _temparray;
            public MyList()//ctor tab tab
            {
                //normal arraylerde arrayı nwelwyip eleman sayısını vermek zorundayız
                _array = new T[0];//yukarıda mylist string newlenip çalışır ve burda 0 olur
            }
            
            
            public void Add(T item)//buraya add operasyonunu ekledik ve add kırmızılığı gitti T yi de ekledik e tipim olarak item yazdık
            {//başlangıçta 
             // BenimList.Add("kars");
             // Console.WriteLine(BenimList.Count);
             //bunları yazıp çalıştırdığımızda bize eleman sayısını 0 verdi oysaki 1 vermesi gerekiyordu
             //o yüzden burada bişeyler yazcaz
             //sıfır elemanlı bir array olduğu için newlememiz gerekiyor ve bir arttırmamız gerekiyor

                _temparray = _array;
                _array = new T[_array.Length + 1];
                Console.WriteLine(item);
                //biz bunu burda yeniden newlediğimiz için tüm önceki verilerimiz uçtu 
                //bu noktada geçiçi bir array oluşturup arrayla = memiz gerekir referans numaralarını
                //temparray şaun referansı tutyor ve şuan aktarmamız gerekir
                //ve bunu forla yapacaz
                for (int i = 0; i <_temparray.Length; i++)
                {
                    _array[i] = _temparray[i];//_arrayin 0. elemanı eşittir _temparrayın 0. elemanını
                }

                //boşta kalan eleman oluyor
                _array[_array.Length - 1] = item;//_arryın son elemanı = olur iteme
                                                 //mesela arrayin son elemanı 4 elemanlı ise 0 1 2 3 itemın 3. elemanı olur

            
            
            
            }

            public int Count
            {
                get { return _array.Length; }//arrayin bana uzunluğunu verecek yani mylistin uzunluğu olacak
            }

          
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
