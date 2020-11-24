

const moeda = document.getElementById('type-coin')
const MoedaFin = document.getElementById('type-fcoin')
const fmoeda = document.getElementById('type-fcoin')
const fvalor = document.querySelector("fvalue")

const real = document.getElementById('real').replace(/,/g, ".");
const bitcoin = document.getElementById('bitcoin').replace(/,/g, ".");
const ether = document.getElementById('ether').replace(/,/g, ".");
const dolar = document.getElementById('dolar').replace(/,/g, ".");

//


function simular2() {
    //function Calc() {
    switch (moeda.value) {
        case "real":
            switch (MoedaFin.value) {
                case "dolar":
                    valorreal = document.getElementById("value").value;
                    //Dolar

                    dolar_ = document.getElementById("DolarCot").innerText;
                    res_dolar = dolar_.replace(/,/g, ".");
                    resultado_dolar = (valorreal / res_dolar).toFixed(2);
                    document.querySelector("[name='fvalue']").value = resultado_dolar;
                    break
                case "ethereum":
                    //eth
                    valorreal = document.getElementById("value").value;
                    ETH = document.getElementById("EthCot").innerText;
                    res_ETH = ETH.replace(/,/g, ".");
                    resultado_ETH = (valorreal / res_ETH).toFixed(2);
                    document.querySelector("[name='fvalue']").value = resultado_ETH;
                    break
                case "bitcoin":
                    //Bit
                    valorreal = document.getElementById("value").value;
                    Bit = document.getElementById("BitCot").innerText;
                    res_bit = Bit.replace(/,/g, ".");
                    resultado_BIT = (valorreal / res_bit).toFixed(2);
                    document.querySelector("[name='fvalue']").value = resultado_BIT;
                    break
                case "real":
                    alert("Não é possivel converter real para real!")
            }
        break
        case "dolar":
            switch (MoedaFin.value) {
                case "real":
                //real
                    valordorlar = document.getElementById("value").value;
                    US = document.getElementById("DolarCot").innerText;
                    cot_dolar = US.replace(/,/g, ".");
                    resultado_real = (valordorlar * cot_dolar).toFixed(2);
                    document.querySelector("[name='fvalue']").value = resultado_real
                    break

               case "bitcoin":
                //Bit
                    valordorlar = document.getElementById("value").value;
                    US = document.getElementById("DolarCot").innerText;
                    cot_dolar = US.replace(/,/g, ".");
                    resultado_real = (valordorlar * cot_dolar).toFixed(2);

                Bit = document.getElementById("BitCot").innerText;
                res_bit = Bit.replace(/,/g, ".");
                resultado_BIT = (resultado_real / res_bit).toFixed(2);
                    document.querySelector("[name='fvalue']").value = resultado_BIT;
                break

               case "ethereum":
                    //ETH
                    valordorlar = document.getElementById("value").value;
                    US = document.getElementById("DolarCot").innerText;
                    cot_dolar = US.replace(/,/g, ".");
                    resultado_real = (valordorlar * cot_dolar).toFixed(2);

                    ETH = document.getElementById("EthCot").innerText;
                    res_eth = ETH.replace(/,/g, ".");
                    resultado_ETH = (resultado_real / res_eth).toFixed(2);
                    document.querySelector("[name='fvalue']").value = resultado_ETH;
                    break
                case "dolar":
                    alert("Não é possivel converter dolar para dolar!")

            }
        break

        case "bitcoin":
            switch (MoedaFin.value) {
                case "real":
                //real
                valorBit = document.getElementById("value").value;
                Bit = document.getElementById("BitCot").innerText;
                    resultado_converReal = (valorBit * Bit).toFixed(2);
                    document.querySelector("[name='fvalue']").value = resultado_converReal;
                    break
                case "dolar":
                    //dolar
                    valorBit = document.getElementById("value").value;
                    Bit = document.getElementById("BitCot").innerText;
                    resultado_converReal = (valorBit * Bit);

                    US = document.getElementById("DolarCot").innerText;
                    cot_dolar = US.replace(/,/g, ".");
                    resultado_real = (resultado_converReal / cot_dolar).toFixed(2);
                    document.querySelector("[name='fvalue']").value = resultado_real;
                    break
                case "ethereum":
                    //ETH
                    valorBit = document.getElementById("value").value;
                    Bit = document.getElementById("BitCot").innerText;
                    resultado_converReal = (valorBit * Bit);

                    ETH = document.getElementById("EthCot").innerText;
                    res_ETH = ETH.replace(/,/g, ".");
                    resultado_ETH = (resultado_converReal / res_ETH).toFixed(2);
                    document.querySelector("[name='fvalue']").value = resultado_ETH;
                    break
                case "bitcoin":
                    alert("Não é possivel converter bitcoin para bitcoin!")

            }
            

            break

        case "ethereum":
            switch (MoedaFin.value) {
                case "real":
                        //real
                    valorETH = document.getElementById("value").value;
                    ETH = document.getElementById("EthCot").innerText;
                    cot_ETH = ETH.replace(/,/g, ".");
                    resultado_real = (valorETH * cot_ETH).toFixed(2);
                    document.querySelector("[name='fvalue']").value = resultado_real;
                    break
                case "dolar":
                    //dolar
                    valorETH = document.getElementById("value").value;
                    ETH = document.getElementById("EthCot").innerText;
                    cot_ETH = ETH.replace(/,/g, ".");

                    dolar_ = document.getElementById("DolarCot").innerText;
                    res_dolar = dolar_.replace(/,/g, ".");
                    resultado_converReal = (valorETH * cot_ETH);
                    resultado_dolar = (resultado_converReal / res_dolar).toFixed(2);
                    document.querySelector("[name='fvalue']").value = resultado_dolar;
                    break

                case "bitcoin":
            //Bit
                    valorETH = document.getElementById("value").value;
                    ETH = document.getElementById("EthCot").innerText;
                    cot_ETH = ETH.replace(/,/g, ".");

                    Bit = document.getElementById("BitCot").innerText;
                    res_bit = Bit.replace(/,/g, ".");
                    resultado_conversaoBIT = (valorETH * cot_ETH);
                    resultado_BIT = (resultado_conversaoBIT / res_bit).toFixed(2);
                    document.querySelector("[name='fvalue']").value = resultado_BIT;
                    break
                case "ethereum":
                    alert("Não é possivel converter ethereum para ethereum! ")

            }
            

            break
    }
}
