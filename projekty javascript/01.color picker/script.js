const colors=['green','red','rgba(133,122,200)','#f1152025'];
const btn = document.getElementById('btn');
const color = document.querySelector('.color');

btn.addEventListener('click',function(){
    let randomowa = Math.floor(Math.random()*4);
    document.body.style.backgroundColor = colors[randomowa];
    color.textContent = colors[randomowa];
});

