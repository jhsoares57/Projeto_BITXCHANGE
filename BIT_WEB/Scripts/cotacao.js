const select = document.getElementById('type-coin')
const simulation = document.getElementById('simulation')

const real = document.getElementById('real')
const bitcoin = document.getElementById('bitcoin')
const ether = document.getElementById('ether')
const dolar = document.getElementById('dolar')


simulation.onclick = () => {
    switch (select.value) {

        case "real":
            // removendo a exibição
            bitcoin.classList.remove('disable')
            ether.classList.remove('disable')
            real.classList.add('disable')
            dolar.classList.remove('disable')

            // adicionando as posições
            bitcoin.style.left = '0%'
            ether.style.left = '41%'
            dolar.style.right = '0%'
            simular()
            break

        case "dolar":
            bitcoin.classList.remove('disable')
            ether.classList.remove('disable')
            real.classList.remove('disable')
            dolar.classList.add('disable')

            bitcoin.style.left = '0%'
            ether.style.left = '41.5%'
            real.style.right = '0%'
            break

        case "bitcoin":
            bitcoin.classList.add('disable')
            ether.classList.remove('disable')
            real.classList.remove('disable')
            dolar.classList.remove('disable')

            ether.style.left = '0%'
            real.style.left = '41.5%'
            dolar.style.right = '0%'
            break

        case "ethereum":
            bitcoin.classList.remove('disable')
            ether.classList.add('disable')
            real.classList.remove('disable')
            dolar.classList.remove('disable')

            bitcoin.style.left = '0%'
            real.style.left = '41.5%'
            dolar.style.right = '0%'

            simular()

            break
    }
}


const moeda = document.getElementById('type-coin')
const teste = document.getElementById('simulation')

function simular() {
    //function Calc() {
    switch (moeda.value) {
        case "real":
            valorreal = document.getElementById("value").value;
            //Dolar

            dolar_ = document.getElementById("DolarCot").innerText;
            res_dolar = dolar_.replace(/,/g, ".");
            resultado_dolar = (valorreal / res_dolar).toFixed(2);
            document.querySelector("[name='us-simulation']").value = resultado_dolar;

            //eth
            //valorreal = document.getElementById("real").value;
            ETH = document.getElementById("EthCot").innerText;
            res_ETH = ETH.replace(/,/g, ".");
            resultado_ETH = (valorreal / res_ETH).toFixed(2);
            document.querySelector("[name='eth-simulation']").value = resultado_ETH;

            //Bit
            //valorreal = document.getElementById("real").value;
            Bit = document.getElementById("BitCot").innerText;
            res_bit = Bit.replace(/,/g, ".");
            resultado_BIT = (valorreal / res_bit).toFixed(2);
            document.querySelector("[name='btc-simulation']").value = resultado_BIT;
            break
        case "dolar":

            //real
            valordorlar = document.getElementById("value").value;
            US = document.getElementById("DolarCot").innerText;
            cot_dolar = US.replace(/,/g, ".");
            resultado_real = (valordorlar * cot_dolar).toFixed(2);
            document.querySelector("[name='rs-simulation']").value = resultado_real

            //Bit
            Bit = document.getElementById("BitCot").innerText;
            res_bit = Bit.replace(/,/g, ".");
            resultado_BIT = (resultado_real / res_bit).toFixed(2);
            document.querySelector("[name='btc-simulation']").value = resultado_BIT;

            //ETH
            ETH = document.getElementById("EthCot").innerText;
            res_eth = ETH.replace(/,/g, ".");
            resultado_ETH = (resultado_real / res_eth).toFixed(2);
            document.querySelector("[name='eth-simulation']").value = resultado_ETH;
            
            break

        case "bitcoin":

            //real
            valorBit = document.getElementById("value").value;
            Bit = document.getElementById("BitCot").innerText;
            resultado_converReal = (valorBit * Bit);
            document.querySelector("[name='rs-simulation']").value = resultado_converReal;

            //dolar
            US = document.getElementById("DolarCot").innerText;
            cot_dolar = US.replace(/,/g, ".");
            resultado_real = (resultado_converReal / cot_dolar).toFixed(2);
            document.querySelector("[name='us-simulation']").value = resultado_real

            //ETH
            ETH = document.getElementById("EthCot").innerText;
            res_ETH = ETH.replace(/,/g, ".");
            resultado_ETH = (resultado_converReal / res_ETH).toFixed(2);
            document.querySelector("[name='eth-simulation']").value = resultado_ETH;
           
            break

        case "ethereum":
            //real
            valorETH = document.getElementById("value").value;
            ETH = document.getElementById("EthCot").innerText;
            cot_ETH = ETH.replace(/,/g, ".");
            resultado_real = (valorETH * cot_ETH).toFixed(2);
            document.querySelector("[name='rs-simulation']").value = resultado_real

            //dolar
            dolar_ = document.getElementById("DolarCot").innerText;
            res_dolar = dolar_.replace(/,/g, ".");
            resultado_converReal = (valorETH * cot_ETH);
            resultado_dolar = (resultado_converReal / res_dolar).toFixed(2);
            document.querySelector("[name='us-simulation']").value = resultado_dolar;

            //Bit
            
            Bit = document.getElementById("BitCot").innerText;
            res_bit = Bit.replace(/,/g, ".");
            resultado_conversaoBIT = (valorETH * cot_ETH);
            resultado_BIT = (resultado_conversaoBIT / res_bit).toFixed(2);
            document.querySelector("[name='btc-simulation']").value = resultado_BIT;
           
            break
    }
}