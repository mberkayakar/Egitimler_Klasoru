// alert("Aritematik Operatörler Ve Matematiksel işlemler ")


let value;  // sonuçları hep buna atayacağız

const value1 = 20; //1. değer tanımlandı
const value2 = 30; //2. değer tanımlandı


value = value1 + value2;  // iki sayı toplandı 
console.log(value1 , " + " ,value2 , " = " , value)   //50


value = value1 - value2  // iki sayı birbirlerinden çıkartıldı.
console.log(value1 , " - " ,value2 , " = " , value) // -10

value = value1 * value2  // iki sayı birbirleriyle çarpıldı.
console.log(value1 , " X " ,value2 , " = " , value) // 600

value = value1 / value2  // iki sayı birbirleriyle Bölündü.
console.log(value1 , " / " ,value2 , " = " , value) // 0.6666

value = value2 % value1  // ilk sayının ikincisine modu
console.log(value2 , " % " ,value1 , " = " , value)  // 10 30 mod 20 = 10
 




                    /*   MEATEMATİK KÜTÜPHANESİ    */
                        
                        
console.log("Pi Sayısı : " ,Math.PI) // value değerine pi sayısını verir. 3.141592653589793

console.log("E (Doğal Logaritma Katsayısı) Sayısı : " ,Math.E) // value değerine pi sayısını verir. 2.718281828459045

console.log("Yuvarlama işlemleri : ",Math.round(5.22))  //  5 . dan sonra sı 5 ten büyükse direk 6 yapar.

console.log("Yuvarlama işlemleri (Ceill): ",Math.ceil(5.01))  //  yukarı yuvarlama işlemidir. 5 ten sonra herhangi bir sayı varsa 0 dan büyük direk 6 yapar

console.log("Yuvarlama işlemleri (Ceill): ",Math.floor(5.99))  //  aşağı yuvarlama işlemidir. 5 ten sonra herhangi bir sayı varsa 0 dan büyük direk 5 yapar

console.log("Karekök alma işlemi : ", Math.sqrt(4))  // 2 yapar 

console.log("üs alma işlemi : ", Math.pow(4,2))  // 16 yapar (eğer içeri tek parametre yollarsan not a number (NaN) cevabını döndürür.)

console.log("Mutlak değer işlemi -25 için ", Math.abs(-25)) // mutlak değere koyar.

// MAXİMUM VE MİNİMUM OPERATÖRLERİ 

// Math kütüphanesinin içinde bulunan ve bir dizi içerisinde ki sayıların max ve min değerlerini çeviren işlemdir. 

var dizi = [1,5, 12 , 8 , 22, 6 , -3 , 2 , 0]

console.log( dizi ," dizisi içerisindeki maximum değer :" ,Math.max(...dizi) , " Minimum Değeri : ", Math.min(...dizi)); 

// dizisel kullanımı yukarıdaki biçimde gösterilmiş bulunmatkadır. Normalde her bir parametreyi tek tek elle vermek üzerine çalışan bu fonksiyon parametre olarak diziyi kabul etmemektedir. Fakat biz bu şekilde kabul ettirebilmekteyiz. 


// console.log(Math.max(1,2,3,5,4) ," -----  " , Math.min(1,2,3,5,4))



