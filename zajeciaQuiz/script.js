const pytania = [{
    pytanie: "Czy widzisz jakiekolwiek nieprawidłowości na liściach, łodygach lub bulwach ziemniaka?",
    odpowiedzi: ["Tak","Nie"],
    przejscieDoNastepnegoPytania: [1,5],
    wyjacnienie: "testowe wyjasnienie na razie",
    numerPytania: 0,
    zdjecie: "1.jpg"
},{
    pytanie: "Jakie objawy są widoczne na liściach?",
    odpowiedzi: ["Brązowe plamy na brzegach liści","Żółte liście z zielonymi nerwami","Liście są skręcone i zdeformowane"],
    przejscieDoNastepnegoPytania: [2,3,4],
    wyjacnienie: [],
    numerPytania: 1,
    zdjecie: "2.jpg" 

},{
    pytanie: "",
    odpowiedzi: [],
    przejscieDoNastepnegoPytania: [],
    wyjacnienie: "Wysoka wilgotność → Może to być zaraza ziemniaka (Phytophthora infestans) → Zastosuj fungicydy systemowe (metalaksyl, cymoksanil) Niska wilgotność → Może to być alternarioza (Alternaria solani) → Stosuj opryski na bazie miedzi lub chlorotalonilu",
    numerPytania: 2 ,
    zdjecie: "3.jpg" 
},{
    pytanie: "",
    odpowiedzi: [],
    przejscieDoNastepnegoPytania: [],
    wyjacnienie: "Może to być wirus mozaiki ziemniaka → Usuń chore rośliny i stosuj odmiany odporne",
    numerPytania: 3 ,
    zdjecie: "3.jpg" 
},{
    pytanie: "",
    odpowiedzi: [],
    przejscieDoNastepnegoPytania: [],
    wyjacnienie: "Stosuj środki owadobójcze na mszyce, które przenoszą wirusy",
    numerPytania: 4 ,
    zdjecie: "3.jpg" 
}
,{
    pytanie: "Czy bulwy mają uszkodzenia, przebarwienia lub deformacje?",
    odpowiedzi: ["Tak","Nie"],
    przejscieDoNastepnegoPytania: [6,10],
    wyjacnienie: [],
    numerPytania: 5 ,
    zdjecie: "3.jpg" 
},{
    pytanie: "Jakie są widoczne objawy na bulwach?",
    odpowiedzi: ["Czernienie i miękkość bulw","Suche, brązowe plamy wewnątrz bulwy","Białe plamy lub przebarwienia"],
    przejscieDoNastepnegoPytania: [7,8,9],
    wyjacnienie: "",
    numerPytania: 6 ,
    zdjecie: "3.jpg" 
},{
    pytanie: "",
    odpowiedzi: [],
    przejscieDoNastepnegoPytania: [],
    wyjacnienie: "Sprawdź wilgotność gleby:\nWysoka wilgotność → Może to być mokra zgnilizna (Pectobacterium carotovorum) → Usuń chore bulwy, stosuj środki dezynfekujące w glebie Niska wilgotność → Może to być sucha zgnilizna (Fusarium spp.) → Przechowuj bulwy w suchych warunkach, stosuj fungicydy",
    numerPytania: 7 ,
    zdjecie: "3.jpg" 
},{
    pytanie: "",
    odpowiedzi: [],
    przejscieDoNastepnegoPytania: [],
    wyjacnienie: "Może to być rizoktonioza (Rhizoctonia solani) → Zaprawiaj bulwy przed sadzeniem, stosuj odpowiednie fungicydy",
    numerPytania: 8 ,
    zdjecie: "3.jpg" 
},{
    pytanie: "",
    odpowiedzi: [],
    przejscieDoNastepnegoPytania: [],
    wyjacnienie: "Może to być parch ziemniaka (Streptomyces scabies) → Wapnuj glebę, obniżaj jej pH, stosuj rotację upraw",
    numerPytania: 9 ,
    zdjecie: "3.jpg" 
},{
    pytanie: "Czy łodygi są uszkodzone lub zdeformowane?",
    odpowiedzi: ["Tak","Nie"],
    przejscieDoNastepnegoPytania: [11,15],
    wyjacnienie: "",
    numerPytania: 10 ,
    zdjecie: "4.jpg" 
},{
    pytanie: "Czy uszkodzenia są wilgotne lub śluzowate?",
    odpowiedzi: ["Tak","Nie"],
    przejscieDoNastepnegoPytania: [12,13],
    wyjacnienie: "",
    numerPytania: 11 ,
    zdjecie: "3.jpg" 
},{
    pytanie: "",
    odpowiedzi: [],
    przejscieDoNastepnegoPytania: [],
    wyjacnienie: "Może to być czarna nóżka (Erwinia spp.) → Usuń chore rośliny, stosuj środki bakteriobójcze w glebie",
    numerPytania: 12 ,
    zdjecie: "3.jpg" 
},{
    pytanie: "Czy łodygi są zdeformowane lub mają puste wnętrza?",
    odpowiedzi: ["Tak","Nie"],
    przejscieDoNastepnegoPytania: [14,16],
    wyjacnienie: "",
    numerPytania: 13 ,
    zdjecie: "3.jpg" 
},{
    pytanie: "",
    odpowiedzi: [],
    przejscieDoNastepnegoPytania: [],
    wyjacnienie: "Może to być gangrena ziemniaka (Phoma exigua) → Usuń zainfekowane rośliny, stosuj odpowiednie fungicydy",
    numerPytania: 14 ,
    zdjecie: "3.jpg" 
},{
    pytanie: "",
    odpowiedzi: [],
    przejscieDoNastepnegoPytania: [],
    wyjacnienie: "Roślina może być zdrowa, monitiruj rośline i sprawdź za pewien czas",
    numerPytania: 15 ,
    zdjecie: "3.jpg" 
},{
    pytanie: "Czy widoczne są inne objawy na roślinie?",
    odpowiedzi: ["Białe, mączyste naloty na liściach","Fioletowy odcień na łodygach","Małe, zdeformowane bulwy","Brak widocznych objawów"],
    przejscieDoNastepnegoPytania: [17,18,19,20],
    wyjacnienie: "",
    numerPytania: 16 ,
    zdjecie: "3.jpg" 
},{
    pytanie: "",
    odpowiedzi: [],
    przejscieDoNastepnegoPytania: [],
    wyjacnienie: "Może to być mączniak rzekomy (Peronospora) → Zastosuj fungicydy na bazie miedzi, popraw cyrkulację powietrza wokół roślin",
    numerPytania: 17 ,
    zdjecie: "3.jpg" 
},{
    pytanie: "",
    odpowiedzi: [],
    przejscieDoNastepnegoPytania: [],
    wyjacnienie: "Może to być zaraza ziemniaka → Natychmiastowe opryski fungicydami (metalaksyl, cymoksanil)",
    numerPytania: 18 ,
    zdjecie: "3.jpg" 
},{
    pytanie: "",
    odpowiedzi: [],
    przejscieDoNastepnegoPytania: [],
    wyjacnienie: "Może to być rak ziemniaka (Synchytrium endobioticum) → Zastosuj kwarantannę na polu, stosuj odporne odmiany",
    numerPytania: 19 ,
    zdjecie: "3.jpg" 
},{
    pytanie: "",
    odpowiedzi: [],
    przejscieDoNastepnegoPytania: [],
    wyjacnienie: "Roślina może być zdrowa lub wymaga dalszej obserwacji",
    numerPytania: 20 ,
    zdjecie: "3.jpg" 
},{
    pytanie: "",
    odpowiedzi: [],
    przejscieDoNastepnegoPytania: [],
    wyjacnienie: "",
    numerPytania: 9 ,
    zdjecie: "3.jpg" 
}];



const przyc = document.getElementById("przyciskPytania");
const pytanieCont = document.getElementById("pytanie");
const odpowiedzCont = document.getElementById("odpowiedziID");
const wyjasnienieCont = document.getElementById("wyjasnienie");


let licznikTeraz = 0;


window.onload = function(e){ 
    let terazniejszyobiekt = pytania[0];
    let terazniejszePytanie = terazniejszyobiekt.pytanie;
    pytanieCont.innerHTML = terazniejszePytanie;
    terazniejszyobiekt.odpowiedzi.forEach((element) => {
        odpowiedzCont.innerHTML += '<div class="pojedynczePytanie"><label for="'+element+'"><input type="radio" class="test" name="wspolnaNazwa" id="'+element+'"> '+element+'</label></div>'; 
        
    });
    wyjasnienieCont.innerHTML = '<img src="'+terazniejszyobiekt.zdjecie+'" alt="">';
    
}

przyc.addEventListener("click", function() {
    let licznik = 0;
    const test = document.getElementsByName("wspolnaNazwa");
    console.log(test)
    for(let i = 0; i < test.length; i++){
        if(test[i].checked){
            licznik = i;
        }
    }
    licznikTeraz = pytania[licznikTeraz].przejscieDoNastepnegoPytania[licznik];
    console.log(licznikTeraz);

    console.log(licznik);
    odpowiedzCont.innerHTML = "";
    let terazniejszyObiektDoNowegoPytania = pytania[licznikTeraz];
    let terazniejszePytanie = terazniejszyObiektDoNowegoPytania.pytanie;
    pytanieCont.innerHTML = terazniejszePytanie;
    terazniejszyObiektDoNowegoPytania.odpowiedzi.forEach((element) => {


        odpowiedzCont.innerHTML += '<div class="pojedynczePytanie"><label for="'+element+'"><input type="radio" name="wspolnaNazwa" id="'+element+'"> '+element+'</label></div>'; 

    });
    wyjasnienieCont.innerHTML = '<img src="'+terazniejszyObiektDoNowegoPytania.zdjecie+'" alt=""><p>'+terazniejszyObiektDoNowegoPytania.wyjacnienie+'</p>';
  });