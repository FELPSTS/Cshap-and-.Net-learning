Algoritmo "pagamento"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 21/02/2025
Var
// Seção de Declarações das variáveis 
    NomeFuncionario:caracter
    valorHORA,pagamento:real
    horatrabalhada:inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores,
   escreva("nome=")
   leia(NomeFuncionario)
   escreva("valor por hora=")
   leia(valorHORA)
   escreva("hora trabalhada=")
   leia(horatrabalhada)
   
   pagamento <- valorHORA * horatrabalhada
   escreval(pagamento)
Fimalgoritmo