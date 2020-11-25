
function Calc() {

    valorreal = document.getElementById("real").value;
    //Dolar
    
    dolar = document.getElementById("cotDolar").innerText;
    res_dolar = dolar.replace(/,/g, ".");
    document.getElementById("dolar_Simu").innerHTML = (valorreal / res_dolar);

    //eth
    //valorreal = document.getElementById("real").value;
    ETH = document.getElementById("CotETH").innerText;
    res_ETH = ETH.replace(/,/g, ".");
    document.getElementById("eth_Simu").innerHTML = (valorreal / res_ETH);

    //Bit
    //valorreal = document.getElementById("real").value;
    Bit = document.getElementById("CotBit").innerText;
    res_bit = Bit.replace(/,/g, ".");
    document.getElementById("BitCoin_Simu").innerHTML = (valorreal / res_bit);

}
