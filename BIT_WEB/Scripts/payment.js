const boleto = document.getElementById('boleto')
const cartao = document.getElementById('cartao')
const final = document.getElementById('final')
const finalCard = document.getElementById('final-card')


function boletoActive() {
    boleto.style.display = 'block'
    cartao.style.display = 'none'
}

function cartaoActive() {
    boleto.style.display = 'none'
    cartao.style.display = 'block'
}

function taxa() {
    const deposito = document.querySelector('#value-deposit')
    const valueCard = document.querySelector('#value-card')
    var valor = Number(deposito.value) + (Number(deposito.value) * 0.0399)
    var valorCard = Number(valueCard.value) + (Number(valueCard.value) * 0.0399)
    final.value = valor.toFixed(2)
    finalCard.value = valorCard.toFixed(2)
}
