Algoritmo "troco"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 06/03/2025
Var
// Se��o de Declara��es das vari�veis 
     preco, dinheiro, troco, resto: real
     quantidade:inteiro

Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
escrevaL("preco unitario")
leia(preco)

escreval("quantidade comprada")
leia(quantidade)

escreval("dinheiro recebido")
leia(dinheiro)

    se dinheiro >= (quantidade * preco) entao
       troco <- dinheiro - preco * quantidade
    escrevaL("troco=",troco:4:2)
    senao
         resto <-preco*quantidade - dinheiro
         escreval ("dinheiro faltam",resto:4:2,"REAIS")
         fimse
    

Fimalgoritmo