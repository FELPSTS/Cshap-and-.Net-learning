Algoritmo "diabetes"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 06/03/2025
Var
// Se��o de Declara��es das vari�veis 
glicose:real


Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
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