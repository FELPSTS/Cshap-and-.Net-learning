Algoritmo "bhaskara"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 24/02/2025
Var
   // Se��o de Declara��es das vari�veis
   a, b, c, x1, x2, delta: real

Inicio
   // Se��o de Comandos, procedimento, fun��es, operadores, etc...
   escreval("Digite o valor de A:")
   leia(a)
   escreval("Digite o valor de B:")
   leia(b)
   escreval("Digite o valor de C:")
   leia(c)

   // C�lculo do delta
   delta <- (b * b) - (4 * a * c)

   // Verifica��o se h� ra�zes reais
   se (a = 0) ou (delta < 0) ent�o
       escreval("ESTE X N�O POSSUI RAIZ")
   senao
       x1 <- (-b + raizQ(delta)) / (2 * a)
       x2 <- (-b - raizQ(delta)) / (2 * a)
       escreval("X1: ", x1)
       escreval("X2: ", x2)
   fimse

Fimalgoritmo