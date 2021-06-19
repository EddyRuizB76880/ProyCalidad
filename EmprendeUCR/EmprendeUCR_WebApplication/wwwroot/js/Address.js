function getValue(id){
	var select = document.getElementById(id);
	return select.options[select.selectedIndex].text;
}

function contrasenaIncorrecta(mensaje) {
	alert(mensaje);
}

function getSelectedValues(id){
	var checkbox = document.getElementById(id);
	if(checkbox.checked == true){
		return parseInt(checkbox.value);
	} else {
		return -1;
	}
}

function resetOption(id){
	document.getElementById(id).value = "";
}

function enabled(id){
	document.getElementById(id).disabled = false;
}

function alerta(message) {
	alert(message);
}