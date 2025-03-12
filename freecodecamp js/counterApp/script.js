let counter = 0;

const incrent = document.getElementById("incrent");
const save = document.getElementById("save");
const previesEnt = document.getElementById("previesEnt");
const count = document.getElementById("count");

incrent.addEventListener("click",() =>{
    counter++;
    count.textContent = counter;
});

save.addEventListener("click",()=>{
    let countStr = counter + " - ";
    previesEnt.textContent += countStr;
    count.textContent = 0;
    counter = 0;
});
