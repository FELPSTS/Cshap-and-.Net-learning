Algoritmo "notas"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 24/02/2025
Var
// Se��o de Declara��es das vari�veis 
   num , ndois, nfinal : real

Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
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