var ValidaTransferencia = function (evento) {

    if (confirm("Confirma a transferência?")) {

        return true;
    }
    else {
        event.preventDefault();
        return false;
    }
}
