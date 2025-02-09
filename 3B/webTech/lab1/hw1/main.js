text1=document.getElementById("from1");
//text2=document.getElementById("from2");
text3=document.getElementById("from3");
sp1 = document.getElementById("sp1");
sp2 = document.getElementById("sp2");
sp3 = document.getElementById("sp3");

function convert1() {
  //
  let x=parseInt(document.getElementById("from1").value);
  let sp=x+" دولار = ";
  x*=60;
  sp+=x+" يمني ";
  sp1.innerHTML=(sp);
}

function convert2(x) {
  //
  //let x = parseInt(document.getElementById("from2").value);
  let sp = x + " دولار = ";
  x *= 60;
  sp += x + " يمني ";
  sp2.innerHTML = (sp);
}

function convert3(y=0) {
  //
  let x = parseInt(document.getElementById("from3").value);
  let sp = x + " دولار = ";
  x *= parseInt(y);
  sp += x + " يمني ";
  sp3.innerHTML = (sp);
}
