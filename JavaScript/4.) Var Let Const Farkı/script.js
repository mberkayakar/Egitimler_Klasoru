var a ;
console.log(a);
// undefined 


let b ;
console.log(b);

// undefined 



// const değer sabit olduğundan ötürü ilk tanımlanma anında değer atanması gerekmektedir. yoksa sistemi
const c =20;
console.log(c);




var ahmet ="Ahmet";
var ahmet ="Mehmet";
console.log(ahmet);

// Bu şekilde tanımlama yapmamıza izin vermektedir.


// let Mehmet = "Hasan"
// let Mehmet = "hüseyin"

// // Görüldüğü gibi hata vermektedir. 


// çalışır
if(true) {
    var deger = 20
}

console.log(deger)



//çalışmaz

if(true) {
    let deger2 = 20
}

console.log(deger2)