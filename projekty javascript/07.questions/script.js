//using selector inside the element 

const questions = document.querySelectorAll('.question');

questions.forEach(function(question){
    const btn = question.querySelector('.question-btn');
    btn.addEventListener('click',function(){

        questions.forEach(function(item){
            if(item !== question){
                item.classList.remove('active');
            }
        })

        question.classList.toggle('active');
    });
});

/*traversing the dom
const questionBtn = document.querySelectorAll('.question-btn');

questionBtn.forEach(function(btn){
    btn.addEventListener('click',function(e){
        const question = e.currentTarget.parentElement.parentElement;
        question.classList.toggle('active');
    });
});*/
