

# VARIAVEIS E TIPOS PRIMITIVOS 

CSharp é uma linguagem estaticamente tipada. Significa que precisar definir o tipo antes de usa-los.  
Para declarar variáveis em C# utilizando uma sintax semelhante ao java e ao C   
```
int myInt = 1;
float myFloat = 1f;
bool myBoolean = true;
string myName = "John";
char myChar = 'a';
double myDouble = 1.75;

```

Note que o dados com ponto fluante necessitando utilizar a letra 'F' como identificação no tipo de dado.  

C# suporta inferencia de tipos. Ou seja, nem sempre será necessário informar o tipo de dada conterá na váriavel, o compilador tentará compreender automaticamente. Ele não fara operações em variaveis de tipos diferentes.

```
var x = 1;
var y = 2;
var sum = x + y; 

```

### Enum

Enums são inteiros que devem ser usados quando um número inteiro é usado para especificar uma opção de uma quantidade fixa de opções

```
public enum CarType
{
    Toyota = 1,
    Honda = 2,
    Ford = 3,
}

public class Tutorial
{
    public static void Main()
    {
        CarType myCarType = CarType.Toyota;
    }
}

```

## EXERCICIO DE REPASSE

Crie 3 variáveis

Uma string chamada productName valor TV.   
Uma integer chamada productYear valor 2012.   
E outra double chamada productPrice valor 279.99.
