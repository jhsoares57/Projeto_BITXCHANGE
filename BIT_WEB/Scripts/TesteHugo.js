var IdUser = function (tipo) {
    id = document.getElementById("Iduser").innerText;
    //window.location.href = "Cambio/" + id;
    if (tipo == 1) {
        return "Cambio/" + id;
    }
    else if(tipo == 2){
        return "principal/" + id;
    }
    return "principal/" + id;
}