function ValorFInTransferencia() {

    ValorInicial = document.getElementById("value").value;
    valorFin = (Number(1.5 / 100) * ValorInicial).toFixed(2);
    document.getElementById("Value-end").innerHTML = valorFin;
       
}