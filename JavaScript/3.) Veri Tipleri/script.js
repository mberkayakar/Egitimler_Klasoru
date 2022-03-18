// Tek satırlık açıklama işareti 

/*
Çoklu 
Satırda  Yoruma Alma işi
*/ 





/* Değişken Oluşturma */ 

var a = 20;           // Number
console.log(a)
console.log(typeof a)

var b = 3.14          //Number
console.log(b)
console.log(typeof b)

var c = "Berkay"     //string
console.log(c)
console.log(typeof c)

var d = true ;      // Boolean
console.log(d);
var d = false ;     
console.log(d);
console.log(typeof d)


var e = null;      // Null veri tipi (hiçbir değer taşımaz)
console.log(e)
console.log(typeof e)


var f ;
console.log(f);
console.log(typeof f)

// bir değişken oluşturulup içerisine hiçbir şekilde atama yapılmadıysa hiç değer 
// verilmemiş manasına gelen undefined kullanılır. 




/*  REFERANS VERİ TİPLERİ : */ 

// Diziler 

var numbers = [1,2,3,4,5];  // array (içerisine birden fazla veri tipini alabilmektedir).
console.log(numbers , typeof numbers , numbers[0], numbers[1])
//      direk diziyi verir | object yazar | dizi 0.eleman | dizi 1.Eleman




// Nesneler 
var person = {name : "Berkay" , Surname : "AKAR" , Age : 22 }
console.log(person , typeof person , person.Age , person.name, person.Surname)
// json gibi obje basar , tip obje , Elemanlara bu şekil tek tek erişim 



// Zaman Tipleri :
var date = new Date();
console.log(date,typeof date , date.getDate(), date.getHours() , date.getSeconds())



// Fonkisyon Tipleri
var merhaba = function(){
    console.log("Merhaba Fonksiyonu Çalıştırıldı ")
}

merhaba(); // Çalıştırma Şekli 
console.log(typeof merhaba)  // Funciton Yazdırır.
console.log(merhaba)  // Fonksiyonunun içini verir. (içerisindeki kodları gösterir.))


// Refernas Ve Primitive (ilkel) Veri tipinin Farklılıkları :

var a = 5 
var b ;

b = a ;
console.log(a,b);
a = a+4;
console.log(a,b)

// a nın değeri b ye kopyalandı. Fakat a değeri artmasına rağmen b de sayı sabit kaldı.
// a ve b için heap üzerinde ayrı yerler ve değerleri oluşturuldu (referans verilmedi )

function Primitive_Hatirlatma_ve_Deneme(){
    var a = 5 
    var q ;

    a = q ;
    console.log(a,b);
    a = a+4;
    console.log(a,b)
   
    // undefined undefined olacaktıu çünkü değersiz bişeyi değerli bi şeye eşitliyoruz mantık hatası 
       }
 
var insan = {isim : "Berkay",Soyisim : "Akar", yaş : 22} 
var insan2 = {isim : "Ahmet",Soyisim : "Ferdi", yaş : 23}

console.log(insan,insan2)

insan = insan2 
console.log(insan,insan2)

insan.Soyisim = "DEĞİŞİKLİK HER İKİ TARAFTA DA GERÇEKLEŞTİ"
console.log(insan,insan2)














// a nın değeri b ye kopyalandı. Fakat a değeri artmasına rağmen b de sayı sabit kaldı.
// a ve b için heap üzerinde ayrı yerler ve değerleri oluşturuldu (referans verilmedi )




// console.log(a , "A nın değeri , " , b , " B nin değeri ", c  , "C nin değeri ");
// // console.log(a , "A nın değeri , " + b + " B nin değeri "+ c  + "C nin değeri ");


// console.log(a  + b + c  , "Toplamlarının değeri ");                           // toplama yaparsan int stringe döner virgülle ayırırsan ayrı tip olur.
// console.log(a  , b , c );                                                     //yazdırma işleminde + da virgül de kullanabilirsin




// console.log(typeof (a , "A nın değeri , " , b , " B nin değeri ", c  , "C nin değeri "));
// console.log( typeof (a + "A nın değeri , " + b + " B nin değeri "+ c  + "C nin değeri "));          // ikisinide string olarak algılar . 



