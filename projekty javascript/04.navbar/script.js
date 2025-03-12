const toggle = document.querySelector('.nav-toggle');
const links = document.querySelector('.links');
toggle.addEventListener('click',function(e){
    links.classList.toggle('show-links');
})