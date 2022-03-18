let value;


// veri tiplerini stringe çevirme : 
value = 123;
console.log(value , " --  Tipi : " , typeof value);
// veri tipi bize number olarak dönmektedir. 

value = String(value);
console.log(value , " --  Tipi : " , typeof value);
// bu şekilde veri tipi string e çevrildi.

value = String(function berkay() { console.log("ahmet")} )
// bir farklı dönüşüm tipi ise (değer).Tostring methodu dur.

value = 187;
console.log(value , " --  Tipi : " , typeof value);

value = value.toString();
console.log(value , " --  Tipi : " , typeof value);


/* Anlaşılacağı üzere ya 

String() yada 

(değişken_ismi).ToStiring()

Yöntemleri ile bir castring Mevcuttur.
*/  




// diğer tiplerden number tipine dönüşüm 


value = Number("325")
console.log(value , " --  Tipi : " , typeof value);


value = Number(null)
console.log(value , " --  Tipi : " , typeof value);
// çevirim işlemini 0 olarak yapacak 


value = Number(undefined)
console.log(value , " --  Tipi : " , typeof value);
// çevrimi yapar içi not a number tipinden  (nan) olur
// bu yüzden hatalı olarak düşünülebilir 


value = Number("AKAR")
console.log(value , " --  Tipi : " , typeof value);
// hatalı bir dönüşüm yapacaktır not a number (nan) kısacası dönüşüm gerçekleşmeyecektir 

value = Number("3.14")
console.log(value , " --  Tipi : " , typeof value);
// number olarak çevirecektir.


value = parseInt("3.14")
console.log(value , " --  Tipi : " , typeof value);
value = parseFloat("3.14")
console.log(value , " --  Tipi : " , typeof value);




// console.log(typeof (a , "A nın değeri , " , b , " B nin değeri ", c  , "C nin değeri "));
// console.log( typeof (a + "A nın değeri , " + b + " B nin değeri "+ c  + "C nin değeri "));          // ikisinide string olarak algılar . 

/* bir sayı ile bir string toplanırsa sistem otomatik olarak ikisinide string olarak çevirip concrete işlemi gerçekleştirir. üstteki console.log işlemini yaparken dikkat etmemiz gereken iki sayısal nicelik toplanmayacaksa hem virgül hem + kullanılanbilir (+ kullanıldığı an string e cast eder ) ama satısal bir nicelik toplanacağonda , işaretinin kullanmamız gerekir.

*/ 


