Algoritmo "troco"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 06/03/2025
Var
// Seção de Declarações das variáveis 
     preco, dinheiro, troco, resto: real
     quantidade:inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
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