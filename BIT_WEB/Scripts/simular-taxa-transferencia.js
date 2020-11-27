const finalt = document.getElementById("Value-end")

function taxaTrans()
{
    const valor_trans = document.getElementById("value").value
    //var ValorInicial = document.getElementById("value").value;
    var valorFin = (Number(1.5 / 100) * valor_trans)
    finalt.value = valorFin.toFixed(2);
       
}