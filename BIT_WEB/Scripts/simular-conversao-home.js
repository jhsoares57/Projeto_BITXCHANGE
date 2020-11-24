const fvalue = document.getElementById('fvalue')

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

function Fvalor() {

    valorreal = document.getElementById("real").values.toFixed(2);

    if (document.getElementsByName("type-fcoin").values == "real") {
        //document.getElementById("fvalue").innerHTML = valorreal;
        fvalue.value = valorreal.toFixed(2);

    }//Dolar
    else if (document.getElementByName("type-fcoin").values == "dolar") {

        dolar = document.getElementById("CotDolar").innerText;
        res_dolar = dolar.replace(/,/g, ".");
        //document.getElementById("fvalue").innerHTML = (valorreal / res_dolar);
        fvalue.value = (valorreal / res_dolar).toFixed(2);
    }
    //eth
    else if (document.getElementByName("type-fcoin").values == "ethereum") {

        ETH = document.getElementById("CotETH").innerText;
        res_ETH = ETH.replace(/,/g, ".");
        //document.getElementById("fvalue").innerHTML = (valorreal / res_ETH);
        fvalue.value = (valorreal / res_ETH).toFixed(2);
    }
    else {
        //Bit
        //valorreal = document.getElementById("real").value;
        Bit = document.getElementById("CotBit").innerText;
        res_bit = Bit.replace(/,/g, ".");
        //document.getElementById("fvalue").innerHTML = (valorreal / res_bit);
        fvalue.value = (valorreal / res_bit).toFixed(2);
    }
}