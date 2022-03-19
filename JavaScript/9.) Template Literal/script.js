// EcmaScript 6 ile birlikte gelen Literallere bakacağız.

const name = "Muhammed Berkay Akar"
const department = "Software Enginer"
const salary = 4000;

const a = "İsim: " + name + "\n" + "department : " + department + "\n" + "Maaş : " + salary;
console.log(a)  

// üstteki yazımın daha kullanışlı yöntemi ES6 ile birlikte gelmiş bulunmaktadır.

const b = ` İsim : ${name} \n Departman : ${department}  \n Maaş Bilgisi : ${salary}`
console.log(b)  


// işaretin oluşturulması için Alt gr + noktalı virgül (noktalı virgüle 2 defa basılması)

const html = "<ul>" + 
"<li> " +   name + "</li>" + 
"<li> " +  department + "</li>" + 
"<li> " +   salary + "</li>" + "</ul>";

document.body.innerHTML = html + "<br> <br>";





const html2 = `<ul> 
                
                    <li>  İSMİM  (ES6): ${"Berkay AKAR"}  </li>
                    <li>  Departman Bilgisi :   (ES6): ${"Çaycı"}  </li>
                    <li>  Maaş  (ES6): ${"4250"}  </li>

                    `


document.body.innerHTML += html2;

 