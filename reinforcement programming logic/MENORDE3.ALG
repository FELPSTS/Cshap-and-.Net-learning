Algoritmo "menorde3"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 27/02/2025
Var
// Se��o de Declara��es das vari�veis 
   v1,v2,v3,vm : inteiro

Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
   escreval("primeiro valor para comparar")
   leia(v1)
   escreval("primeiro valor para comparar")
   leia(v2)
   escreval("primeiro valor para comparar")
   leia(v3)

   se ( v1 < v2 ) e ( v1 < v3 ) entao
   vm <- v1
      senao
      se( v2 < v3 ) entao
      vm <- v2
         senao
         vm <- v3
      fimse
   fimse
   escreva("o valor menor �"vm)
Fimalgoritmo
