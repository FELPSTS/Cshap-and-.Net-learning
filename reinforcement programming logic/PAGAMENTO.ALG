Algoritmo "pagamento"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 21/02/2025
Var
// Se��o de Declara��es das vari�veis 
    NomeFuncionario:caracter
    valorHORA,pagamento:real
    horatrabalhada:inteiro

Inicio
// Se��o de Comandos, procedimento, fun��es, operadores,
   escreva("nome=")
   leia(NomeFuncionario)
   escreva("valor por hora=")
   leia(valorHORA)
   escreva("hora trabalhada=")
   leia(horatrabalhada)
   
   pagamento <- valorHORA * horatrabalhada
   escreval(pagamento)
Fimalgoritmo