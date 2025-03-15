Algoritmo "diabetes"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 06/03/2025
Var
// Seção de Declarações das variáveis 
glicose:real


Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
   escreval("digite a media de glicose:")
   leia(glicose)
   
   se glicose <= 100.0 entao
   escreval("normal")
         senao
         se (glicose > 100.0)e(glicose <= 140) entao
         escreval("elevado")
            senao
            escreval("classificacao:diabetes")

      fimse
   fimse

Fimalgoritmo