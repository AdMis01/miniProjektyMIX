let myLeads = [];

let inputSave = document.getElementById("inputSave");
const inputEl = document.getElementById("inputEl");
const unOrderList = document.getElementById("unOrderList");
const btnDelete = document.getElementById("btnDelete");
const saveTab = document.getElementById("saveTab");

const leadsFromLocalStorage = JSON.parse(localStorage.getItem("myLeads"));
if(leadsFromLocalStorage){
    myLeads = leadsFromLocalStorage;
    render(myLeads);
}


function render(leads){
    let listItems = "";
    for(let i = 0; i < leads.length;i++){
        listItems += `<li><a href="#" target="_blank">${leads[i]}</a></li>`;
    }
    unOrderList.innerHTML = listItems;
}

inputSave.addEventListener("click",function(){
    myLeads.push(inputEl.value);
    inputEl.value = "";
    localStorage.setItem("myLeads",JSON.stringify(myLeads));
    render(myLeads);
});

btnDelete.addEventListener("dblclick",function(){
    localStorage.clear();
    myLeads = [];
    render(myLeads);
});

saveTab.addEventListener("click",function(){
    chrome.tabs.query({active: true, currentWindow: true}, function(tabs) {
        myLeads.push(tabs[0].url);
        localStorage.setItem("myLeads",JSON.stringify(myLeads));
        render(myLeads);
    });
});