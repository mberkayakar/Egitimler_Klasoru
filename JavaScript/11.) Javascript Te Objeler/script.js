const programmer = { 
    firstname : "Berkay",
    Lastname : "Akar",
    Age : 22 ,
    Work_on : ["Web" , "Desktop" , "Mobil"],
    Language : ["C#" , "Java" , ".NET" , "Core"],

    // iç içe objeler kullanılmaktadır. 

    Adress : {
        City :"İstanbul",
        State : "Bayrampaşa",
        Full_Adress : "Kartaltepe MAhallesi 22 / 2  "
    },

    selamlama_fonkiyonu  : function()
    {
        console.log("Selamın Aleyküm");
    }


 }


 // üstte gözüktüğü gibi bazı alanlar tek değer , bazıları fonksiyon , bazıları iç içe objeler , bazıları ise diziler şeklinmde tanımlanmıştır.


 console.log(programmer.firstname , " -- ",  programmer.Lastname);
 console.log();
 console.log(programmer.Age , " Yaşında  ");
 console.log();
 console.log("Çalıştığı teknolojler : ");
 for (let index = 0 ; index < programmer.Work_on.length ; index++ ){
     console.log(index + "  -  " +programmer.Work_on[index])

 }
 console.log("  ");


 console.log("Diller : ");
 for (let index = 0 ; index < programmer.Language.length ; index++ ){
     console.log(index + "  -  " +programmer.Language[index])

 }
 console.log();
 console.log(" Adress : "+programmer.Adress.City + " " + programmer.Adress.State  + "  " + programmer.Adress.Full_Adress)
console.log()

programmer.selamlama_fonkiyonu();


// bu şekilde bir erişim olabileceği gibi bir başka erişim şeklide bir aşağıda belirtilmiştir. 

console.log(programmer["Adress"].City);



// firs json app 


const programmers = [
    {name :"Berkay" , age : 22  },
    {name :"Mahmut" , age : 22  }

]

// bu dizi objelerden oluşan bir arraydir.

for (let index = 0; index < programmers.length; index++) {
    console.log (programmers[index].name , "     " , programmers[index].age);
    
}