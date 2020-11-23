var ValidaTransferencia = function (evento) {

    if (confirm("Confirma essa transação?")) {

        return true;
    }
    else {
        event.preventDefault();
        return false;
    }
}


var TransfereBitCoin = function (id,evento) {

    if (confirm("Confirma essa transação?")) {

        var urlbit = id + "/bitcoin/Cambio";
        window.location.href = urlbit;
        return true;
    }
    else {
        event.preventDefault();
        return false;
    }
}
