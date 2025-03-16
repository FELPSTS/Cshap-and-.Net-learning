Algoritmo "odômetro"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 21/02/2025
Var
// Seção de Declarações das variáveis 
        distancia,combustivelgasto,consumomedio:real
Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
   escreval("quanto voce percorreu em KM?")
   leia(distancia)
   escreval("quanto de combusticel voce utilizou")
   leia(combustivelgasto)
   
   consumomedio <- (distancia / combustivelgasto)
   escreval("seu consumo medio por km rodaddo foi de:", consumomedio:4:3)
Fimalgoritmo