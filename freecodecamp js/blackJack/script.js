let sum = 0;
let allCards = [];
let hasBlackJack = false;
let isAlive = false;
let message = "";
let startGameBtn = document.getElementById("startGame");
let messageEl = document.getElementById("message-el");
let sumEl = document.getElementById("sum");
let cards = document.querySelector("#cards");
let drawCardBtn = document.querySelector(".drawCard");


let player = {
    name: "Per",
    chips: 200
}

let playerMon = document.getElementById("playerMon");
playerMon.textContent = player.name + ": $" + player.chips;

function getRandomCard(){
    let random = Math.floor(Math.random()*13)+1;
    if(random>10){
        return 10;
    }else if(random === 1){
        return 11;
    }else{
        return random;
    }
}
function startGame(){
    isAlive = true;
    let firstCard=getRandomCard();
    let secondCard=getRandomCard();
    sum = firstCard+secondCard;
    allCards = [firstCard,secondCard];
    renderGame();
}

function renderGame(){
    sumEl.textContent = `Suma: ${sum}`;
    cards.textContent = `Cards: `;
    for(let i=0;i<allCards.length;i++){
        cards.textContent += ` ${allCards[i]}`;
    }

        if(sum <= 20){
            message = "do you want do draw a second card?";
        }else if(sum === 21){
            message = "you got a blackjack";
            hasBlackJack = true;
        }else{
            message = "you lost!";
            isAlive = false;
        }
        messageEl.textContent = message;
}
function nextCard(){
    if(isAlive && hasBlackJack === false){
        let nextCard = getRandomCard();
        sum += nextCard;
        allCards.push(nextCard);
        cards.textContent += nextCard;
        renderGame();
    }
}
startGameBtn.addEventListener("click",startGame);

drawCardBtn.addEventListener("click",nextCard);

