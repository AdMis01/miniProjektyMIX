var i = 0;

function odliczaj(){
	i = i + 1;
	postMessage(i);
	setTimeout("odliczaj()",50);
}

odliczaj();