let count = 0;

const btn = document.querySelectorAll('.btn');
const value = document.querySelector('#value');

btn.forEach(function(btton){
    btton.addEventListener('click', function(e){
        const styles = e.currentTarget.classList;
        if(styles.contains('decrease')){
            count--;
        }else if(styles.contains('reset'))
        {
            count = 0;
        }else{
            count++;
        }
        if(count<0){
            value.style.color = 'red';
        }
        else if(count>0){
            value.style.color = 'green';
        }
        else if(count === 0){
            value.style.color = 'black';
        }
        value.textContent = count;
    })
})