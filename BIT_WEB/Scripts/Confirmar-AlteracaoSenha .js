var ValidaAlteracao = function (evento) {
    senha_ = document.getElementById("nova-senha").value;
    Confsenha_ = document.getElementById("conf-senha").value;
    if (senha_ == Confsenha_) {
        if (confirm("Confirma essa transação?")) {

            return true;
        }
        else {
            event.preventDefault();
            return false;
        }

    }
    else {
        alert("Senhas não conferem!")
            event.preventDefault();
            return false;
    }
    
}
