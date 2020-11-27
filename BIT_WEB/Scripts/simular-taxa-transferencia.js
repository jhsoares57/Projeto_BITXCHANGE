const finalt = document.getElementById("Value-end")

function taxaTrans()
{
    const valor_trans = document.getElementById("value").value
    var valorFin = (Number(1.5 / 100) * Number(valor_trans));
    var valorFim = (Number(valorFin) + Number(valor_trans));
    finalt.value = valorFim.toFixed(2); 
}