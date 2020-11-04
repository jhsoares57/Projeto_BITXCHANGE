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
            break
    }
}