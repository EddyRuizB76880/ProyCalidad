function getValue(id){
	var select = document.getElementById(id);
	return select.options[select.selectedIndex].text;
}