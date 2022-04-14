

async function GetCards(name)
{
    var address = "http://127.0.0.1:5500/api/Card/GetCard/" + name; 
    fetch(address)
    .then(response => response.json)
    .then(data => CullData(data) )
    .catch(err => alert(err));
}

function CullData(object)
{
    console.log(object);    
}



const button1 = document.getElementById("0");
button1.innerText = "click me!"
button1.addEventListener('click',GetCards("0"));