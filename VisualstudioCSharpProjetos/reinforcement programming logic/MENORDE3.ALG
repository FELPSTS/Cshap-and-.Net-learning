Algoritmo "menorde3"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 27/02/2025
Var
// Seção de Declarações das variáveis 
   v1,v2,v3,vm : inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
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
   escreva("o valor menor é"vm)
Fimalgoritmo
