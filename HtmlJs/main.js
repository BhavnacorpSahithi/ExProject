function getdata(){
     var name=  document.getElementById("name").value;
     var email=  document.getElementById("email").value;
    alert(name +" you are logged emails is:"+ email);
}

function show(){
   var data =  document.getElementById("data");
   if(data.style.display==="none"){
       data.style.display = "block"
   }else {
       data.style.display="none"
   }
}

function Random(){
   var letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
   var strlength=6;
   var random = "";

   for(var i=0;i<strlength;i++){
    var rnum = Math.floor(Math.random()*letters.length);
    random += letters.substring(rnum,rnum+1);
   }
   document.getElementById("randstr").innerHTML = random;
}



