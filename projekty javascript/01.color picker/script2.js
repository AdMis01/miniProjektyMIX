const colors2=['0','1','2','3','4','5','6','7','8','9','A','B','C','D','F'];
const btn2 = document.getElementById('btn2');
const color = document.querySelector('.color');
btn2.addEventListener('click',function(){
    let pojemik='#';
    for(let i = 0; i < 6;i++)
    {
        let randomowa = Math.floor(Math.random()*15);
        pojemik += colors2[randomowa];
    }
    document.body.style.backgroundColor = pojemik;
    color.textContent = pojemik;
},false);
