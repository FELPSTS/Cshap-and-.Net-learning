Algoritmo "od�metro"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 21/02/2025
Var
// Se��o de Declara��es das vari�veis 
        distancia,combustivelgasto,consumomedio:real
Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
   escreval("quanto voce percorreu em KM?")
   leia(distancia)
   escreval("quanto de combusticel voce utilizou")
   leia(combustivelgasto)
   
   consumomedio <- (distancia / combustivelgasto)
   escreval("seu consumo medio por km rodaddo foi de:", consumomedio:4:3)
Fimalgoritmo