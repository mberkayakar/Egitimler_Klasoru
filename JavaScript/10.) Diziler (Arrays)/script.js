/*              Diziler                 */ 

let value;

value=[1,2,3,4,5,6]      // let value2= new Array(1,2,3,4,5,6)  // iki yöntem de kullanılıyor
const lang = ["Python","Java","C++","JavaScript"]
const karisik = ["Berkay","Akar",1,2,3,4,5,6,null,undefined,3.14,Date.now()]


console.log(value)
console.log(lang)
console.log(karisik)



// bir dizideki eleman uzunluguna bakma 
console.log(value.length)

 // bir dizideki indexe göre eleman çağırma 
console.log("Value dizisindeki 2. Eleman :",value[2]);  // string içerisinde char at çalışıyor fakat dizilerde CharAt Bulunmamamktadır.


// Herhangi Bir İndexteki Elemanı Değiştirme
console.log(value) // 1,2,3,4,5,6
value[3] = 99;
console.log(value) // 1,2,3,99,5,6


// index of (eleman varsa değerini döndürecek, yoksa -1 çevirecek)

console.log(value.indexOf(99)) // 3.bilgisini döndürdü. Çünkü Kendisi 3. İndex te 

// dizilere eleman ekleme ve silme  (Pop - push - unshift - shift  )
value.push("Akar");
console.log(value)  // ekleme en sonuncu index e yapıldı. 

// push en sona ekleme yaparken aradaEn başa   ekleme yapılacaksa = unshift methodu kullanılmalıdır
value.unshift(2,"Balıkesie")  // 2 tane eleman yolladım sırası ile ilk iki eleman bu şekilde
console.log(value)

value.unshift(5,"Gönen",187)  // 3 eleman yollandı.
console.log(value)

value.pop()
console.log(value) // en sonraki değeri silmiş oldu 

value.shift();
console.log(value)  // en baştaki 5 çıkartılmış oldu 

// belirlenen indexler arası değer atmak için 

//  ['Gönen', 187, 2, 'Balıkesie', 1, 2, 3, 99, 5, 6]  son durumdaki dizi hali 

value.splice(0,3)  // son elemanı almaz yani 0 1 2. elemanları atar
console.log(value)  // başlangıç ve bitiş indexleri 


// dizilerdeki elemanları tam tersine çevirme 
value.reverse()  
console.log(value)  // tüm elemanları ters yaptı. 


// dizilerde sıralama
value.sort() 
console.log(value)

value.sort(function(x,y){
    // küçükten büyüğe 
    return x-y
})

value.sort(function(x,y){
    // Büyükten Küçüğe s 
    return y-x
}) 



console.log(value)