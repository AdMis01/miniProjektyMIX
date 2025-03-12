const toggle = document.querySelector('.toggle');
const sidebar = document.querySelector('.sidebar');
const remove = document.querySelector('.remove');

toggle.addEventListener('click',function(){
    sidebar.classList.toggle('active');
})
remove.addEventListener('click',function(){
    sidebar.classList.remove('active');
})
/*
toggle.addEventListener('click',function(){
    if(sidebar.classList.contains(active))
    {
        sidebar.classList.remove('active');
    }else{
        sidebar.classList.add('active');
    }
})
*/
