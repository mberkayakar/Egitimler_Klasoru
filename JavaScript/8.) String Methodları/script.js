let value;  // konsole ekranına basması için tanımlanmış bir değişken

var firstname = "Berkay";
var LastName = "Akar"

const Langs = "Java,Python,C++"





//                          String işlemleri : 


value = firstname + LastName
console.log("İki Stringin Toplanmış Hali : ",value);

// += ile üstüne ekleme yapma :  (value = value + degisken == value += degisken)

value += " 2022 "
console.log("İki Stringin Toplanmış Hali + += operatörü ile  : ",value);

// bir stringin uzunlugunu bulmak lenght komutu ile gerçekleştir.

console.log("String uzunluğu : ",value.length);

// += yada + ile iki stringi toplayabildiğimiz gibi diğer programlama dillerinden de hakim olduğumuz concat eklenebilir.

console.log(firstname.concat(LastName).concat(" 2022").concat(firstname.length));

// aynı zamanda istediğin kadar da concat içerisinde parametre verebilirisin 

console.log(firstname.concat(LastName,value,LastName.length,"2022 ","Concat parametreli"))

// lower ve upper ile büyük küçük dönüşümü 
console.log(firstname.toUpperCase() , " " , firstname.toLowerCase()) 


//string ifadeler aynı diğer dillerde  de oldugu gibi özünde bir dizi görevi göremektedir.

value= "Berkay"

for (var index = 0; index < value.length; index++)
{
    console.log(index , " . Harf : ",value[index])
}


// indexteki herhangi bir elemanın yerine yeni bir karakter ile değişltirme mevcut değildir.
value[2] = "A"
value[3] = "A"


console.log("Değiştirilmiş hali : " ,value)


// bu yüzden bu yöntemi kullanmamız gerekemetkedir. 

String.prototype.replaceAt = function(index, replacement) {
    return this.substr(0, index) + replacement + this.substr(index + replacement.length);
}


value = value.replaceAt(2,"Qq");

console.log("Değiştirilmiş hali (ReplaceAtlıHali): " ,value)


// bir string içerisinde bir karakter veya metin aramak istiyorsak index of methodlarını kullanabiliriz. 

value = "Berkay akar ";

console.log(value.indexOf("a")); // 
// eğer içerisinde A geçen (Pascall Case dir büyük küçüğü farklı algılar.) bir değer var ise soldan başlayarak bulunduğu değeri bizlere iletir.  Bulamaz ise -1 sonucuu döndürmektedir. 

console.log(value.lastIndexOf("a"));  // 9
// buda sondan bulduğu değeri getirir.

// ikiside birden fazla olup olmadığına bakmaz. birisi ilk buldugunu getirir soldan başlar
// diğeri soldan başlar ve ilk buldugunu getirir.

// ikiside sola göre konumlarını getirir.



/*   CHAR - AT   */
value = "Berkay akar";
console.log(value.charAt(0) , " ---- " , value[0])   // B ---- B Döndü sonuç olarak 
// hangi indexte hangi karakter oldugunu gösteren bir fonksiyondur.
// value[0] ile aynıdır.


// Split (bir string içerisinde belirli bir karaktere göre bölünmüş olan karakteri alabilmektedir.) Bölünen kısımların her birini bir array elemanı olarak yerleştirmetkedir. 

var diller  = "Java,Python,C++"
console.log(diller.split(","))


var diller  = "Java,Python,C++"
dizi = diller.split(",");

for (let index = 0; index < dizi.length; index++) {
    
    console.log(index, " . dizininin elemanı " , dizi[index]);
     
}


// Replace fonksiyonu :

value = "Berkay akar "
value = value.replace("a","T")

console.log(value)


// includes

value = "Berkay akar "
var sonuc = value.includes("akar")
console.log(sonuc)

