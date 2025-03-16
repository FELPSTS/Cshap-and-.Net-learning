Algoritmo "notas"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 24/02/2025
Var
// Seção de Declarações das variáveis 
   num , ndois, nfinal : real

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
   escrevaL("digite a nota 1")
   leia(num)
   escrevaL("digite a nota 2")
   leia(ndois)
   
   nfinal<-num +ndois
   escrevaL(nfinal)
   
   se(nfinal<60.00)entao
   escreval("Reprovado")
     senao
     escreva("aprovado")
   fimse

Fimalgoritmo